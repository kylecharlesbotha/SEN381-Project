import Aux from "../../../hoc/Auxillary";
import "./../Footer/Footer.css";
import "font-awesome/css/font-awesome.min.css";
import "mdb-ui-kit/css/mdb.min.css";

const Footer = () => {
  return (
    <Aux>
      <div className="bg-dark text-center text-lg-start text-white">
        <div className="container">
          <div className="row ">
            <div className="col-md-4 text-center footerheading">
              <h5> SERVICES</h5>
              <p>CRM Systems</p>
              <p>Customer Satisfaction</p>
              <p>Ticketing</p>
              <p>Technical Support</p>
              <p>Hosting</p>
            </div>
            <div className="col-md-4 text-center footerheading">
              <h5> ABOUT</h5>
              <p>Company</p>
              <p>Team</p>
              <p>History</p>
            </div>
            <div className="col-md-4 text-center footerheading">
              <h5> PREMIER SERVICE SOLUTIONS</h5>
              <p>
                We are Premier Service Solutions. A company that will meet all
                your needs and give the very best. We believe in being where you
                are 24/7 to allow us to always be one call or email away. We
                value our customers and their customers also and we promise to
                deliver valuable services and content to all!
              </p>
            </div>
          </div>
        </div>
        <div className="container p-1 pb-0 text-center footersec">
          <section className="mb-4">
            <a
              className="btn btn-floating m-1 btnfacebook"
              href="https://facebook.com"
              role="button"
              target="_blank"
              rel="noreferrer"
            >
              <i className="fa fa-facebook"></i>
            </a>

            <a
              className="btn btn-floating m-1 btntwitter"
              href="https://twitter.com"
              target="_blank"
              role="button"
              rel="noreferrer"
            >
              <i className="fa fa-twitter"></i>
            </a>

            <a
              className="btn btn-floating m-1 btngoogle"
              href="https://google.com"
              role="button"
              target="_blank"
              rel="noreferrer"
            >
              <i className="fa fa-google"></i>
            </a>

            <a
              className="btn btn-floating m-1 btninstagram"
              href="https://instagram.com"
              role="button"
              target="_blank"
              rel="noreferrer"
            >
              <i className="fa fa-instagram"></i>
            </a>

            <a
              className="btn btn-floating m-1 btnlinkedin"
              href="https://linkedin.com"
              role="button"
              target="_blank"
              rel="noreferrer"
            >
              <i className="fa fa-linkedin"></i>
            </a>

            <a
              className="btn btn-floating m-1 btngithub"
              href="https://github.com"
              role="button"
              target="_blank"
              rel="noreferrer"
            >
              <i className="fa fa-github"></i>
            </a>
          </section>
        </div>
        <section className="container newsletter">
          <div className="row  justify-content-center">
            <div className="col-md-3">
              <p className="pt-1">
                <strong>Sign up for our newsletter</strong>
              </p>
            </div>
            <div className="col-md-5 pt-1">
              <input
                type="text"
                className="form-control "
                placeholder="Email Address"
              />
            </div>

            <div className="col-md-3 pt-1">
              <button type="submit" className="btn btn-outline-light mb-4">
                Subscribe
              </button>
            </div>
          </div>
        </section>
        <div className="footer">
          <div className="text-center p-3">
            © 2021 Copyright:
            <a
              className="text-white"
              href="https://premierservicesolutions.co.za"
            >
              PremierServiceSolutions
            </a>
          </div>
        </div>
      </div>
    </Aux>
  );
};

export default Footer;
