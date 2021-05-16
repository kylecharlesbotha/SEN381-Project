import React from "react";
import Aux from "../../../hoc/Auxillary";
import "./Forgot.css";
import Typography from "@material-ui/core/Typography";
import Box from "@material-ui/core/Box";
import Logo from "../../../assets/images/PSSLogo.png";
import { NavLink } from "react-router-dom";
import { useHistory } from "react-router-dom";
import TextField from "@material-ui/core/TextField";

const Forgot = ({ props }) => {
  const browhistory = useHistory();
  console.log(browhistory);

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
              <h2>Are you having trouble signing in?</h2>
              <p className="emailp">Please enter your email linked to your account.</p>
              <TextField
                id="filled-basic Subject"
                label="Email Address"
                required
                name="Emaill Address"
                variant="outlined"
                className=" lblHeader"
                size="small"
                color="secondary"
                style ={{width: '75%'}}
                
              />
              <p className="infop">
                We will send you a email to reset the password for your account
                so you can continue.
              </p>

              <button
                type="submit"
                className="btn btnsignin justify-content-center"
                color="#ff5c5c"
              >
                SEND EMAIL
              </button>
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
