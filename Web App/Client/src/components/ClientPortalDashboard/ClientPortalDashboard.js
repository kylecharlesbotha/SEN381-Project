import React from "react";
import Aux from "../../hoc/Auxillary";
import "../ClientPortalDashboard/ClientPortalDashboard.css";
import Typography from "@material-ui/core/Typography";
import Box from "@material-ui/core/Box";
import Logo from "../../assets/images/PSSLogo.png";
import Ticket from "../../assets/images/Tickets Red.png";
import ClientPortalTickets from "../ClientPortalTickets/ClientPortalTickets"
//import "@trendmicro/react-sidenav/dist/react-sidenav.css";
const logoutHandler = ({history}) => {
  localStorage.removeItem("clientToken");
  history.push("/ClientPortal");
};
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
                        href="/ClientPortal/tickets"
                      >
                        Tickets
                      </a>
                    </Box>
                  </li>
                 
                  
                  
                </ul>
                <ul className="navbar-nav ms-auto">
								<li fontWeight="fontWeightBold" className="nav-item">
									<Box fontWeight="fontWeightBold" m={1}>
										<a className="nav-link active" aria-current="page" href="/">
											Exit portal
										</a>
									</Box>
								</li>
								<li fontWeight="fontWeightBold" className="nav-item">
									<Box fontWeight="fontWeightBold" m={1}>
										<a className="nav-link active" aria-current="page" href="/ClientPortal" onClick={logoutHandler}>
											Logout
										</a>
									</Box>
								</li>
							</ul>
              </div>
            </div>
          </nav>
          <ClientPortalTickets/>
          
        </Box>
      </Typography>
    </Aux>
  );
};

export default ClientPortalDashboard;
