import Aux from "../../../hoc/Auxillary";
import AboutUsImg from "../../../assets/images/HelpDesk.png";
import "./About.css";

const About = () => {
  return (
    <Aux>
      <div id="aboutus"></div>
      <div className="aboutus container bg-light shadow-lg p-2 mb-2 bg-white rounded">
        <div className="row">
          <div className="col-md-6 helpcon">
            <img src={AboutUsImg} className="helpdesk" alt="paper plane" />
          </div>
          <div className="col-md-6 detailscon text-center">
            <h3>ABOUT US</h3>
            <p className="aboutwhop">
              We were founded in 2020, and specialize in turnkey I.T. solutions.
              we are based in Johannesburg and amongst the COVID-19 pandemic
              have grown. We believe in high customer service and delivery on
              that. We started from our garage doing small odd jobs and have
              grown into a fair-sized company but still provide the service of a
              small company. Below we have how much faster we are verses other
              competitive companies.
            </p>

            <div className="skills-bar">
              <p>Call Hold Times</p>
              <div className="progress">
                <div className="progress-bar" style={{ width: "84%" }}>
                  84%
                </div>
              </div>
              <p>Technician Dispatched</p>
              <div className="progress">
                <div className="progress-bar" style={{ width: "88%" }}>
                  88%
                </div>
              </div>
              <p>Ticket Turnaround</p>
              <div className="progress">
                <div className="progress-bar" style={{ width: "94%" }}>
                  94%
                </div>
              </div>
              <p>System Up-Time</p>
              <div className="progress">
                <div className="progress-bar" style={{ width: "99%" }}>
                  99%
                </div>
              </div>
              <p>Client Satisfaction</p>
              <div className="progress">
                <div className="progress-bar" style={{ width: "82%" }}>
                  82%
                </div>
              </div>
              <p>Technical Rating</p>
              <div className="progress">
                <div className="progress-bar" style={{ width: "85%" }}>
                  85%
                </div>
              </div>
              <p>Client Support</p>
              <div className="progress">
                <div className="progress-bar" style={{ width: "90%" }}>
                  90%
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </Aux>
  );
};

export default About;
