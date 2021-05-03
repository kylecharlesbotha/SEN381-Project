import Aux from "../../hoc/Auxillary";
import "./ClientPortal.css";
import Logo from "../../assets/images/PSSLogo.png";
import React from "react";
import { NavLink } from "react-router-dom";
import TextField from "@material-ui/core/TextField";

const ClientPortal = (props) => {
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
      <div className="container">
        <div className="row justify-content-center">
          <div className="col-md-8 justify-content-center text-center bg-light shadow-lg p-2 mb-2 bg-white rounded">
            <h5>Client Portal Login</h5>
            <div className="input-group mb-3">
              <div className="input-group-prepend"></div>
              <TextField
                id="filled-basic"
                label="Name"
                variant="outlined"
                className="form-control lblHeader"
                size="small"
                required
                color="secondary"
              />
            </div>
            <div className="input-group mb-3">
              <div className="input-group-prepend"></div>
              <TextField
                id="filled-basic"
                label="Name"
                variant="outlined"
                className="form-control lblHeader"
                size="small"
                required
                color="secondary"
              />
            </div>
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

export default ClientPortal;
