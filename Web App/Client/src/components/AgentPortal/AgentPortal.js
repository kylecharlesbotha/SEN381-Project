import Aux from "../../hoc/Auxillary";
import { withStyles } from "@material-ui/core/styles";
import { red } from "@material-ui/core/colors";
import "./AgentPortal.css";
import Logo from "../../assets/images/PSSLogo.png";
import React from "react";
import { NavLink } from "react-router-dom";
import TextField from "@material-ui/core/TextField";
import FormControlLabel from "@material-ui/core/FormControlLabel";
import Checkbox from "@material-ui/core/Checkbox";

const RedCheckbox = withStyles({
  root: {
    color: red[400],
    "&$checked": {
      color: red[600],
    },
  },
  checked: {},
})((props) => <Checkbox color="default" {...props} />);

const CssTextField = withStyles({
  root: {
    "& label.Mui-focused": {
      color: "rgb(218,0,0)",
    },
    "& .MuiInput-underline:after": {
      borderBottomColor: "rgb(218,0,0)",
    },
    "& .MuiOutlinedInput-root": {
      "& fieldset": {
        borderColor: "lightgray",
      },
      "&:hover fieldset": {
        borderColor: "black",
      },
      "&.Mui-focused fieldset": {
        borderColor: "rgb(218,0,0)",
      },
    },
  },
})(TextField);

const AgentPortal = (props) => {
  return (
    <Aux>
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
      <div className="container logincont">
        <div className="row justify-content-center bg-light shadow-lg  bg-white rounded-start">
          <div className="col-md-6  text-center bg-light shadow-lg bg-white rounded">
            <h5>Agent Portal Login</h5>
            <div className="input-group mb-3">
              <div className="input-group-prepend formin"></div>
              <CssTextField
                id="filled-basic"
                label="Username"
                variant="outlined"
                className="lblHeader inputboxes"
                size="medium"
                required
                color="secondary"
              />
            </div>
            <div className="input-group mb-0">
              <div className="input-group-prepend formin"></div>
              <CssTextField
                className="lblHeader inputboxes"
                label="Password"
                variant="outlined"
                size="medium"
                required
                type="password"
                id="custom-css-outlined-input"
              />
            </div>
            <div className="input-group mb-0">
              <div className="input-group-prepend formin"></div>
              <FormControlLabel
                control={<RedCheckbox name="chkRemeberme" />}
                label="Remeber Me"
                className="chk"
              />
            </div>
            <button
              type="button"
              className="btn btnsignin justify-content-center"
              color="#ff5c5c"
            >
              Login
            </button>
            <div className="input-group justify-content-center">
              <div className="input-group-prepend"></div>
              <a
                href="https://google.com"
                variant="body2"
                className="forgotlink"
              >
                Forgot password?
              </a>
            </div>
          </div>
          <div className="col-md-6 text-center ">
          <img src={Logo} alt="logo" className="logoimg"/>
          </div>
          
        </div>
      </div>
      <div className="text-center p-3 footer">
        © 2021 Copyright:
        <a className="text-dark" href="https://premierservicesolutions.co.za">
          PremierServiceSolutions
        </a>
      </div>
    </Aux>
  );
};

export default AgentPortal;
