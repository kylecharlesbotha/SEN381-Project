import Aux from "../../../hoc/Auxillary";
import "../ContactUs/ContactUs.css";
import Email from "../../../assets/images/EmailEtiquette.png";
import Arrow from "../../../assets/images/arrow.png";
import { makeStyles } from "@material-ui/core/styles";
import TextField from "@material-ui/core/TextField";
import TextareaAutosize from "@material-ui/core/TextareaAutosize";
import "font-awesome/css/font-awesome.min.css";

const ContactUs = () => {
  return (
    <Aux>
      <div
        className="contactus container shadow-lg p-0  mb-5 bg-light rounded"
        id="contactus"
      >
        <div className="row">
          <div className="col-md-6 piccon">
            <img src={Email} className="emailcontactus" alt="paper plane" />
          </div>
          <div className="col-md-6 detailscon text-center">
            <h2>Contact Us</h2>
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
                label="Email Address"
                variant="outlined"
                required
                className="form-control lblHeader"
                size="small"
                color="secondary"
              />
            </div>
            <div className="input-group mb-3">
              <div className="input-group-prepend"></div>
              <TextField
                id="filled-basic"
                label="Subject"
                required
                variant="outlined"
                className="form-control lblHeader"
                size="small"
                color="secondary"
              />
            </div>
            <div className="input-group mb-3">
              <div className="input-group-prepend"></div>
              <TextField
                id="standard-multiline-static"
                label="Message"
                multiline
                required
                variant="outlined"
                className="form-control lblHeader"
                size="small"
                rowsMax={3}
                color="secondary"
              />
            </div>
            <button
              type="button"
              className="btn btn-dark btnsendemail btn-rounded"
            >
              Send Email
              <img src={Arrow} className="sendemailimage" />
            </button>
          </div>
        </div>
      </div>
    </Aux>
  );
};

export default ContactUs;
