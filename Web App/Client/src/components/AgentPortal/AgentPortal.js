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
import { useState, useEffect } from "react";
import axios from "axios";
import { Link } from "react-router-dom";
import { useHistory } from "react-router-dom";

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

const AgentPortal = ({ history }) => {
  const browhistory = useHistory();
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");

  useEffect(() => {
    if (localStorage.getItem("authToken")) {
      history.push("/AgentPortal/Tickets");
    }
  }, [history]);
  const loginHandler = async (e) => {
    e.preventDefault();
    const config = {
      headers: {
        "Content-Type": "application/json",
      },
    };

    try {
      const { data } = await axios.post(
        "http://41.1.77.120:3001/api/auth/loginEmployee",
        { UserName: username, UserPassword: password },
        config
      );
      localStorage.setItem("authToken", data.token);
      history.push("/AgentPortal/Tickets");
    } catch (error) {
      console.dir(error);
      setError(error.response.data.error);
      setTimeout(() => {
        setError("");
      }, 5000);
    }
  };
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
            <form onSubmit={loginHandler}>
              <h5>Agent Portal Login</h5>
              {error && <span>{error}</span>}
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
                  value={username}
                  onChange={(e) => setUsername(e.target.value)}
                  tabIndex={1}
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
                  value={password}
                  onChange={(e) => setPassword(e.target.value)}
                  tabIndex={2}
                />
              </div>
              <div className="input-group mb-0">
                <div className="input-group-prepend formin"></div>
                <FormControlLabel
                  control={<RedCheckbox name="chkRemeberme" />}
                  label="Remember Me"
                  className="chk"
                />
              </div>
              <button
                type="submit"
                className="btn btnsignin justify-content-center"
                color="#ff5c5c"
              >
                Login
              </button>
              <div className="input-group justify-content-center">
                <div className="input-group-prepend"></div>
                <a
                  onClick={() =>
                    browhistory.push("/Password/Forgot/Email", {
                      from: "ClientPortal",
                    })
                  }
                  variant="body2"
                  className="forgotlink"
                >
                  Forgot password?
                </a>
              </div>
            </form>
          </div>

          <div className="col-md-6 text-center ">
            <img src={Logo} alt="logo" className="logoimg" />
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
