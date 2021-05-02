import Aux from "../../../hoc/Auxillary";
import "../ContactUs/ContactUs.css";
import Email from "../../../assets/images/paper_plane.png";
const ContactUs = () => {
  return (
    <Aux>
      <div className="contactus container" id="contactus">
        <div className="row">
          <div className="col-md-6 piccon">
            <img src={Email} className="emailcontactus" alt="paper plane" />
          </div>
          <div className="col-md-6 detcon text-center">
            <h2>Contact Us</h2>
            <div class="input-group mb-3">
              <div class="input-group-prepend"></div>
              <input
                type="text"
                class="form-control"
                placeholder="Username"
                aria-label="Username"
                aria-describedby="basic-addon1"
              />
            </div>
            <div class="input-group mb-3">
              <div class="input-group-prepend"></div>
              <input
                type="text"
                class="form-control"
                placeholder="Email"
                aria-label="Email"
                aria-describedby="basic-addon1"
              />
            </div>
            <div class="input-group mb-3">
              <div class="input-group-prepend"></div>
              <input
                type="text"
                class="form-control"
                placeholder="Subject"
                aria-label="Subject"
                aria-describedby="basic-addon1"
              />
            </div>
          </div>
        </div>
      </div>
    </Aux>
  );
};

export default ContactUs;
