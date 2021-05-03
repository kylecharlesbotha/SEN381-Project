import "./Navigation.css";
import { NavLink } from "react-router-dom";
const Navigation = (props) => {
  return (
    <nav className="navbar navbar-expand-lg navbar-light bg-light shadow-lg p-2 mb-2 bg-white rounded">
      <div className="container-fluid">
        <a className="navbar-brand" href="/">
          Premier Service Solutions
        </a>
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
            <li className="nav-item">
              <a className="nav-link active" aria-current="page" href="/">
                Home
              </a>
            </li>
            <li className="nav-item scroll-to-section">
              <a className="nav-link" href="/">
                About Us
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="/">
                Services
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="/">
                Contact Us
              </a>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link" to="ClientPortal">
                Client Portal
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link" to="AgentPortal">
                Agent Portal
              </NavLink>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};

export default Navigation;
