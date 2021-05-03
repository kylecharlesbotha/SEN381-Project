import "./Navigation.css";
import { NavLink } from "react-router-dom";
import Typography from "@material-ui/core/Typography";
import Box from "@material-ui/core/Box";
import Logo from "../../../assets/images/PSSLogo.png";
const Navigation = (props) => {
  return (
    <Typography component="Div">
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
              <ul className="navbar-nav ms-auto">
                <li fontWeight="fontWeightBold" className="nav-item">
                  <Box fontWeight="fontWeightBold" m={1}>
                    <a className="nav-link active" aria-current="page" href="/">
                      Home
                    </a>
                  </Box>
                </li>
                <li className="nav-item scroll-to-section">
                  <Box fontWeight="fontWeightBold" m={1}>
                    <a className="nav-link" href="/">
                      About Us
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
                <li className="nav-item">
                  <Box fontWeight="fontWeightBold" m={1}>
                    <NavLink className="nav-link" to="ClientPortal">
                      Client Portal
                    </NavLink>
                  </Box>
                </li>
                <li className="nav-item">
                  <Box fontWeight="fontWeightBold" m={1}>
                    <NavLink className="nav-link" to="AgentPortal">
                      Agent Portal
                    </NavLink>
                  </Box>
                </li>
              </ul>
            </div>
          </div>
        </nav>
      </Box>
    </Typography>
  );
};

export default Navigation;
