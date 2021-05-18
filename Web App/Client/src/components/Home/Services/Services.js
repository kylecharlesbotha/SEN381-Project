import Aux from "../../../hoc/Auxillary";
import ServiceImg from "../../../assets/images/ServicesIcon.png";
import "./Services.css";
import Local from "../../../assets/images/service-icon-01.png";
import Repair from "../../../assets/images/service-icon-02.png";
import Voip from "../../../assets/images/service-icon-03.png";
import Hosting from "../../../assets/images/service-icon-04.png";

const Services = () => {
  return (
    <Aux>
      <div id="services">
        <p></p>
      </div>
      <div className="services container ">
        <div className="row ">
          <div className="col-md-4 helpcon">
            <img src={ServiceImg} className="helpdesk" alt="paper plane" />
          </div>
          <div className="col-md-8 Servicescon text-center">
            <h2>Services Offered</h2>
            <p className="aboutwhop">
              Here at Premier Service Solutions we Believe in offering only the
              best of the best serivces to all clients and consumers. Top
              Quality service is Top Quality Support
            </p>
            <div className="row justify-content-center servicecontainer">
              <div className="col-md-5">
                <img
                  src={Local}
                  alt="Local/Remote Support"
                  className="LRImage"
                />
                <h4>Local/Remote Support</h4>
                <p>
                  We provide in house or remote support, Including: setup,
                  anti-virus protection, firewall's, email configuration and
                  more;
                </p>
              </div>
              <div className="col-md-5">
                <img src={Repair} alt="Repair and Maintenance" />
                <h4>Repair and Maintenance</h4>
                <p>
                  We provide various levels of Maintenance on printers,
                  networks, computers and servers as well as repairs for the
                  aforementioned.
                </p>
              </div>
              <div className="col-md-5">
                <img src={Voip} alt="VOIP Services" />
                <h4>VOIP Services</h4>
                <p>
                  Use your existing Internet connection to make affordable voice
                  calls to any telephone number in the world. Plus, all calls to
                  other Pure VoIP numbers are absolutely FREE
                </p>
              </div>
              <div className="col-md-5">
                <img src={Hosting} alt="Hosting" />
                <h4>Hosting</h4>
                <p>
                  IT services that is delivered over the internet or a dedicated
                  cloud network. Services include: Cloud Hosting, Domain Hosting
                  and Website Hosting.
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </Aux>
  );
};

export default Services;
