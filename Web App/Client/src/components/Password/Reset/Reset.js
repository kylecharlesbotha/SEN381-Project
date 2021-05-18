import React from "react";
import Aux from "../../../hoc/Auxillary";
import "./Reset.css";
import Typography from "@material-ui/core/Typography";
import Box from "@material-ui/core/Box";
import Logo from "../../../assets/images/PSSLogo.png";
import { NavLink } from "react-router-dom";
import TextField from "@material-ui/core/TextField";
import Arrow from "../../../assets/images/arrow.png";
import { useState } from "react";
import axios from "axios";
const Reset = ({ match }) => {
  const [password, setPassword] = useState("");
	const [confirmPassword, setConfirmPassword] = useState("");
	const [error, setError] = useState("");
	const [success, setSuccess] = useState("");

	const resetPasswordHandler = async (e) => {
		e.preventDefault();
		const config = {
			headers: {
				"Content-Type": "application/json",
			},
		};
		if (password !== confirmPassword) {
			setPassword("");
			setConfirmPassword("");
			setTimeout(() => {
				setError("");
			}, 5000);
			return setError("Passwords do not match");
		}
		try {
			const { data } = await axios.post(
				`http://premierservicesolutions.flystudio.co.za:3001/api/auth/resetpassword/${match.params.resetToken}`,
				{ password },
				config,
			);
			console.log(data);
			setSuccess(data.data);
		} catch (error) {
			setError(error.response.data.error);
			setTimeout(() => {
				setError("");
			}, 5000);
		}
	};
  return (
     
    <Aux>
      {console.log(success)}
      <Typography component="div">
        <Box>
          <nav className="navbar navbar-expand-lg navbar-light bg-light shadow-lg p-2 mb-2 bg-white rounded">
            <div className="container-fluid">
              <a className="navbar-brand" href="/">
                <img src={Logo} alt="logo" className="logoimg" />
              </a>
              <NavLink
                className="fa fa-arrow-left"
                to="/Home"
                href="/Home"
              ></NavLink>
            </div>
          </nav>
        </Box>
        <div className="input-group-prepend"></div>
        <div className="container justify-content-center">
          <div className="row justify-content-center bg-light shadow-lg p-2 mb-2 bg-white rounded">
            <div className="col-md-8 resetgroup">
            <form onSubmit={resetPasswordHandler}>
                <h2>Change your Password</h2>
                <p>Enter your new account password below. Once confirmed, you'll be logged into your new account and your new password will be active</p>
                <div className="row mb-3">
                  <div className="col-md-5 passwordlabel">
                    <p>Password</p>
                  </div>
                  <div className="col-md-7 passwordentry">
                  <TextField
                    id="filled-basic Email"
                    label="Password"
                    variant="outlined"
                    required
                    name="Email"
                    className="form-control lblHeader mt-2 mb-2"
                    size="small"
                    color="secondary"
                    onChange={(e) => setPassword(e.target.value)}
                  />
                  </div>
                </div>
                <div className="row mb-3">
                  <div className="col-md-5 passwordlabel">
                    <p>Confirm Password</p>
                  </div>
                  <div className="col-md-7 passwordentry">
                  <TextField
                    id="filled-basic"
                    label=" Re-Type Password"
                    variant="outlined"
                    required
                    name="Email"
                    className="form-control lblHeader mt-2 mb-2"
                    size="small"
                    color="secondary"
                    onChange={(e) => setConfirmPassword(e.target.value)}

                  />
                  {error && <span className="error-message">{error}</span>}
                  {success && <span>{success}</span>}
                  </div>
                </div>

                <button
                  type="submit"
                  value="submit"
                  className="btn btn-dark btnchangepassword btn-rounded float-end"
                >
                  Change Password
                </button>
              </form>
            </div>
          </div>
        </div>
      </Typography>
    </Aux>
  );
};

export default Reset;
