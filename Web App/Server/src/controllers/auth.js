const {
  User,
  findOneEmployee,
  findOneClient,
  findOneByPasswordResetToken,
  setPassword,
  findClientEmailByID,
} = require("../models/User");
const ErrorResponse = require("../utils/errorResponse");
const crypto = require("crypto");
const axios = require("axios");

exports.register = async (req, res, next) => {
  const { username, email, password } = req.body;
  try {
    //!Save user to db
    // const user = await User.create({
    //     username, email, password
    // });
    sendToken(user, 201, res);
  } catch (error) {
    next(error);
  }
};

exports.loginEmployee = async (req, res, next) => {
  const { UserName, UserPassword } = req.body;

  if (!UserName || !UserPassword) {
    return next(new ErrorResponse("Authentication failed", 400));
  }

  try {
    //!Get user from db
    var userobj = await findOneEmployee(UserName);

    const user = new User(userobj);
    //var user = await User.findOne({email}).select("+password");
    if (!user) {
      return next(new ErrorResponse("Authentication failed", 401));
    }
    const isMatch = await user.matchPasswords(UserPassword);
    if (!isMatch) {
      return next(new ErrorResponse("Authentication failed", 401));
    }
    sendToken(user, 200, res);
  } catch (error) {
    console.log(error);
    next(error);
  }
};
exports.loginClient = async (req, res, next) => {
  console.log("logging client in");
  const { UserName, UserPassword } = req.body;

  if (!UserName || !UserPassword) {
    return next(new ErrorResponse("Authentication failed", 400));
  }
  console.log("1");
  try {
    //!Get user from db
    var userobj = await findOneClient(UserName);

    const user = new User(userobj);

    //var user = await User.findOne({email}).select("+password");
    if (!user) {
      return next(new ErrorResponse("Authentication failed", 401));
    }

    const isMatch = await user.matchClientPasswords(UserPassword);

    if (!isMatch) {
      return next(new ErrorResponse("Authentication failed", 401));
    }
    sendTokenForClient(user, 200, res);
  } catch (error) {
    console.log(error);
    next(error);
  }
};
exports.forgotpassword = async (req, res, next) => {
  const { username } = req.body;

  try {
    const userobj =
      (await findOneClient(username)) || (await findOneEmployee(username));
    //
    const user = new User(userobj);
    console.dir(user);
    if (!user) {
      return next(new ErrorResponse("Username Error", 404));
    }
    const resetToken = await user.getResetPasswordToken();

    const resetUrl = `http://premierservicesolution.flystudio.co.za/Password/Reset/${resetToken}`;

    try {
      const config = {
        headers: {
          "Content-Type": "application/json",
          to: await findClientEmailByID(user.UserObj.ClientID),
          link: resetUrl,
        },
      };
      try {
        await axios.post(
          "http://flystudio.co.za:7341/sendResetPassword",
          {},
          config
        );
      } catch (error) {
        console.log(error);
        return error;
      }
      // await sendEmail({
      //     to: user.email,
      //     subject: "Password Reset Request",
      //     text: message
      // });

      res.status(200).json({ success: true, data: "Email sent." });
    } catch (error) {
      //user.resetPasswordToken = undefined;
      // user.resetPasswordExpire = undefined;
      await user.save();
      return next(new ErrorResponse("Email Error", 500));
    }
  } catch (error) {
    return next(error);
  }
};
exports.resetpassword = async (req, res, next) => {
  console.log("RESETTTING PWD");
  const resetPasswordToken = crypto
    .createHash("sha256")
    .update(req.params.resetToken)
    .digest("hex");
  try {
    const userOBJ = await findOneByPasswordResetToken(resetPasswordToken);
    const user = new User(userOBJ);

    if (!user) {
      return next(new ErrorResponse("Invalid password reset token", 400));
    }
    //save new pwd and reset token to null  Client
    console.dir(user.UserObj);

    setPassword(user.UserObj.ClientUserName, req.body.password);
    // await user.save();
    res
      .status(201)
      .json({ success: true, data: "Password has been reset succesfully." });
  } catch (error) {
    next(error);
  }
};
const sendToken = (user, statusCode, res) => {
  const token = user.getSignedToken();
  res.status(statusCode).json({ success: true, token });
};
const sendTokenForClient = (user, statusCode, res) => {
  const token = user.getSignedTokenForClient();
  res.status(statusCode).json({ success: true, token });
};
