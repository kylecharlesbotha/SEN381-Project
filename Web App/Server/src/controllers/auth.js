const {User, findOneEmployee, findOneClient} = require('../models/User'); 
const ErrorResponse = require('../utils/errorResponse');

exports.register = async (req, res, next) => {
    const {username, email, password} = req.body;
    try{
        //!Save user to db
        // const user = await User.create({
        //     username, email, password
        // });
        sendToken(user, 201, res);

    }catch (error){
        next(error);
    }
};

exports.loginEmployee = async (req, res, next) => {
    const {UserName, UserPassword} = req.body; 

    if (!UserName || !UserPassword){
        return next(new ErrorResponse("Authentication failed", 400)); 
    };

    try{
        //!Get user from db
        var userobj = await findOneEmployee(UserName)
         
        const user = new User(userobj);
        //var user = await User.findOne({email}).select("+password");
        if (!user){
            return next(new ErrorResponse("Authentication failed", 401)); 
        }
        const isMatch = await user.matchPasswords(UserPassword); 
        if (!isMatch){
            return next(new ErrorResponse("Authentication failed", 401)); 
        }
        sendToken(user, 200, res);
         
    }catch(error){
        console.log(error);
        next(error);
    };
};
exports.loginClient = async (req, res, next) => {
    console.log("logging client in")
    const {UserName, UserPassword} = req.body; 

    if (!UserName || !UserPassword){
        return next(new ErrorResponse("Authentication failed", 400)); 
    };
    console.log("1")
    try{
        //!Get user from db
        var userobj = await findOneClient(UserName)
    console.log("2")
         
        const user = new User(userobj);
        console.log("3")

        //var user = await User.findOne({email}).select("+password");
        if (!user){
            return next(new ErrorResponse("Authentication failed", 401)); 
        }
        console.log("4")
        
        const isMatch = await user.matchClientPasswords(UserPassword); 
        console.log("5")
        if (!isMatch){
            return next(new ErrorResponse("Authentication failed", 401)); 
        }
        sendToken(user, 200, res);
         
    }catch(error){
        console.log(error);
        next(error);
    };
};
const sendToken = (user, statusCode, res) => {
    const token = user.getSignedToken();
    res.status(statusCode).json({success: true, token});
}