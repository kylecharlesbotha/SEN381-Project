import React from "react";
import Aux from "../../hoc/Auxillary";
import "../ClientPortalDashboard/ClientPortalDashboard.css";
import Typography from "@material-ui/core/Typography";
import Box from "@material-ui/core/Box";
import Logo from "../../assets/images/PSSLogo.png";
import Ticket from "../../assets/images/Tickets Red.png";

//import "@trendmicro/react-sidenav/dist/react-sidenav.css";

const ClientPortalDashboard = (props) => {
  return (
    <Aux>
      <Typography component="div">
        <Box>
          <nav className="navbar navbar-expand-lg navbar-light bg-light shadow-lg p-2 mb-2 bg-white rounded">
            <div className="container-fluid">
              <img src={Logo} alt="Logo" className="logoimg" />
              <button
                className="navbar-toggler"
                type="button"
                data-bs-toggle="collapse"
                data-bs-target="#navbarNav"
              >
                <i className="fa fa-bars"></i>
              </button>
              <div className="collapse navbar-collapse" id="navbarNav">
                <ul className="navbar-nav">
                  <li fontWeight="fontWeightBold" className="nav-item">
                    <Box fontWeight="fontWeightBold" m={1}>
                      <a
                        className="nav-link active"
                        aria-current="page"
                        href="/"
                      >
                        Dashboard
                      </a>
                    </Box>
                  </li>
                  <li className="nav-item scroll-to-section">
                    <Box fontWeight="fontWeightBold" m={1}>
                      <a className="nav-link" href="/">
                        Tickets
                      </a>
                    </Box>
                  </li>
                  <li className="nav-item">
                    <Box fontWeight="fontWeightBold" m={1}>
                      <a className="nav-link" href="/">
                        Services
                      </a>
                    </Box>
                  </li>
                  <li className="nav-item">
                    <Box fontWeight="fontWeightBold" m={1}>
                      <a className="nav-link" href="/">
                        Contact Us
                      </a>
                    </Box>
                  </li>
                </ul>
                <ul className="navbar-nav ms-auto">
                  <li fontWeight="fontWeightBold" className="nav-item">
                    <Box fontWeight="fontWeightBold" m={1}>
                      <a className="nav-link" aria-current="page" href="/">
                        <i className="fa fa-power-off" />
                      </a>
                    </Box>
                  </li>
                </ul>
              </div>
            </div>
          </nav>

          <div className="container ticketcont">
            <div className="row justify-content-center">
              <div className="col-md-9 bg-light shadow-lg p-1 mb-2 bg-white rounded">
                <div className="ticketicon">
                  <Box className="redstrip"></Box>
                  <img src={Ticket} alt="ticketicon" className="ticketimage" />
                </div>
                <div className="ticketdetails">
                  <div className="tickettitle">
                    <div className="row">
                      <div className="col-md-4 tickettitleheading">
                        <h5>Ticket Title</h5>
                      </div>
                      <div className="col-md-7 tickettitlework">
                        <p>Printer not working</p>
                      </div>
                    </div>
                  </div>
                  <div className="ticketpriority">
                    <div className="row">
                      <div className="col-md-4 ticketpriorityheading">
                        <h5>Ticket Priority</h5>
                      </div>
                      <div className="col-md-7 ticketprioritywork">
                        <p>High</p>
                      </div>
                    </div>
                  </div>
                  <div className="ticketdesc">
                    <div className="row">
                      <div className="col-md-4 ticketdescheading">
                        <h5>Ticket Description</h5>
                      </div>
                      <div className="col-md-7 ticketdescwork">
                        <p>
                          wdnawdhwajha wjkdbhwajdhwa j wdjiuawhdwaujdhawdhw a
                        </p>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div className="container ticketcont">
            <div className="row justify-content-center">
              <div className="col-md-9 bg-light shadow-lg p-1 mb-2 bg-white rounded">
                <div className="ticketicon">
                  <Box className="redstrip"></Box>
                  <img src={Ticket} alt="ticketicon" className="ticketimage" />
                </div>
                <div className="ticketdetails">
                  <div className="tickettitle">
                    <div className="row">
                      <div className="col-md-4 tickettitleheading">
                        <h5>Ticket Title</h5>
                      </div>
                      <div className="col-md-7 tickettitlework">
                        <p>Printer not working</p>
                      </div>
                    </div>
                  </div>
                  <div className="ticketpriority">
                    <div className="row">
                      <div className="col-md-4 ticketpriorityheading">
                        <h5>Ticket Priority</h5>
                      </div>
                      <div className="col-md-7 ticketprioritywork">
                        <p>High</p>
                      </div>
                    </div>
                  </div>
                  <div className="ticketdesc">
                    <div className="row">
                      <div className="col-md-4 ticketdescheading">
                        <h5>Ticket Description</h5>
                      </div>
                      <div className="col-md-7 ticketdescwork">
                        <p>awjdhwajdh wajdhwa</p>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div className="container ticketcont">
            <div className="row justify-content-center">
              <div className="col-md-9 bg-light shadow-lg p-1 mb-2 bg-white rounded">
                <div className="ticketicon">
                  <Box className="redstrip"></Box>
                  <img src={Ticket} alt="ticketicon" className="ticketimage" />
                </div>
                <div className="ticketdetails">
                  <div className="tickettitle">
                    <div className="row">
                      <div className="col-md-4 tickettitleheading">
                        <h5>Ticket Title</h5>
                      </div>
                      <div className="col-md-7 tickettitlework">
                        <p>Setup New Laptop</p>
                      </div>
                    </div>
                  </div>
                  <div className="ticketpriority">
                    <div className="row">
                      <div className="col-md-4 ticketpriorityheading">
                        <h5>Ticket Priority</h5>
                      </div>
                      <div className="col-md-7 ticketprioritywork">
                        <p>Low</p>
                      </div>
                    </div>
                  </div>
                  <div className="ticketdesc">
                    <div className="row">
                      <div className="col-md-4 ticketdescheading">
                        <h5>Ticket Description</h5>
                      </div>
                      <div className="col-md-7 ticketdescwork">
                        <p>Please set up new laptop and</p>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Typography>
    </Aux>
  );
};

export default ClientPortalDashboard;
