import React from "react";
import Aux from "../../../hoc/Auxillary";
import "./Forgot.css";
import Typography from "@material-ui/core/Typography";
import Box from "@material-ui/core/Box";
import Logo from "../../../assets/images/PSSLogo.png";
import { NavLink } from "react-router-dom";
import { useHistory } from "react-router-dom";
import TextField from "@material-ui/core/TextField";
import { useState } from "react";
import axios from "axios";
const Forgot = ({ props }) => {
  const browhistory = useHistory();
  const [username, setUsername] = useState("");
	const [error, setError] = useState("");
	const [success, setSuccess] = useState("");

	const forgotPasswordHandler = async (e) => {
		e.preventDefault();

		const config = {
			header: {
				"Content-Type": "application/json",
			},
		};
    console.log(username); 
		try {
			const { data } = await axios.post(
				"http://41.1.77.120:3001/api/auth/forgotpassword",
				{ username },
				config,
			);
			setSuccess(data.data);
		} catch (error) {
			setError(error.response.data.error);
			setUsername("");
			setTimeout(() => {
				setError("");
			}, 5000);
		}
	};

  return (
    <Aux>
      <Typography component="div">
        <Box>
          <nav className="navbar navbar-expand-lg navbar-light bg-light shadow-lg p-2 mb-2 bg-white rounded">
            <div className="container-fluid">
              <a className="navbar-brand" href="/">
                <img src={Logo} alt="logo" className="logoimg" />
              </a>
              <NavLink
                className="fa fa-arrow-left"
                onClick={() => {
                  browhistory.goBack();
                }}
                to="/history"
              ></NavLink>
            </div>
          </nav>
        </Box>
        <div className="input-group-prepend"></div>
        <div className="container justify-content-center">
          <div className="row justify-content-center">
            <div className="col-md-7 forgotemail">
              <form onSubmit={forgotPasswordHandler} >
              <h2>Are you having trouble signing in?</h2>
              <p className="emailp">Please enter your email linked to your account.</p>
              <TextField
                id="filled-basic Subject"
                label="Username"
                required
                name="Emaill Address"
                variant="outlined"
                className=" lblHeader"
                size="small"
                color="secondary"
                style ={{width: '75%'}}
                onChange={(e) => setUsername(e.target.value)}
              />
              <p>{error && <span className="error-message">{error}</span>}
                  {success && <span>{success}</span>}</p>
              <p className="infop">
                We will send you a email to reset the password for your account
                so you can continue.
              </p>

              <button
                type="submit"
                className="btn btn-dark btnsendemail btn-rounded"
                color="#ff5c5c"
              >
                SEND EMAIL
              </button>
              </form>
            </div>
            <div className="col-md-3 forgottext">
              <p>
                Don't worry! You have come to the right place if you have
                forgotten your email or password for your account. For security
                purposes we ask that you please provide us your email so we may
                send a email to you with instructions to reset your account
                password
              </p>
            </div>
          </div>
        </div>
        <div className="text-center p-3 footer">
          © 2021 Copyright:
          <a className="text-dark" href="https://premierservicesolutions.co.za">
            PremierServiceSolutions
          </a>
        </div>
      </Typography>
    </Aux>
  );
};

export default Forgot;
