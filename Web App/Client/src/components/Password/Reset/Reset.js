import React from "react";
import Aux from "../../../hoc/Auxillary";
import "./Reset.css";
import Typography from "@material-ui/core/Typography";
import Box from "@material-ui/core/Box";
import Logo from "../../../assets/images/PSSLogo.png";
import { NavLink } from "react-router-dom";

const Reset = (props) => {
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
                to="/Home"
                href="/Home"
              ></NavLink>
            </div>
          </nav>
        </Box>
      </Typography>
    </Aux>
  );
};

export default Reset;
