import React from "react";
import Aux from "../../../hoc/Auxillary";
import "./Forgot.css";
import Typography from "@material-ui/core/Typography";
import Box from "@material-ui/core/Box";
import Logo from "../../../assets/images/PSSLogo.png";
import { NavLink } from "react-router-dom";
import { useHistory } from "react-router-dom";

function Forgot({ props }) {
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
        <p></p>
      </Typography>
    </Aux>
  );
}

export default Forgot;
