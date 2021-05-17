import Aux from "../../../hoc/Auxillary";
import "../ContactUs/ContactUs.css";
import Email from "../../../assets/images/EmailEtiquette.png";
import Arrow from "../../../assets/images/arrow.png";
import TextField from "@material-ui/core/TextField";
import "font-awesome/css/font-awesome.min.css";
import React from "react";

class ContactUs extends React.Component {
  constructor() {
    super();
    this.state = {
      input: {},
      errors: {},
    };

    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleChange(fieldName) {
    return function (event) {
      let input = this.state.input;
      input[event.target.name] = event.target.value;
      this.validate();
      this.setState({
        input,
      });
    };
  }

  handleSubmit(event) {
    event.preventDefault();

    if (this.validate()) {
      let input = {};
      input["Name"] = "";
      input["Email"] = "";
      input["Subject"] = "";
      input["Message"] = "";
      this.setState({ input: input });

      const requestOptionsCustomer = {
        method: "POST",
        headers: {
          to: this.state.input.Email,
          subject: "Contact Us",
          heading: this.state.input.Subject,
          name: this.state.input.Name,
          message: this.state.input.Message,
        },
      };
      fetch(
        "http://flystudio.co.za:7341/sendClientContactUs",
        requestOptionsCustomer
      )
        .then((response) => response.json())
        .then((data) => this.setState({ postId: data.id }));

      const requestOptionsEmployee = {
        method: "POST",
        headers: {
          to: "contactus@flystudio.co.za",
          subject: "New Contact Us",
          heading: this.state.input.Subject,
          name: this.state.input.Name,
          email: this.state.input.Email,
          message: this.state.input.Message,
        },
      };
      fetch(
        "http://flystudio.co.za:7341/sendEmployeeContactUs",
        requestOptionsEmployee
      )
        .then((response) => response.json())
        .then((data) => this.setState({ postId: data.id }));
    }
  }
  validate() {
    let input = this.state.input;
    let errors = {};
    let isValid = true;

    if (!input["Name"]) {
      isValid = false;
      errors["Name"] = "Please enter your Name!";
    }

    if (!input["Email"]) {
      isValid = false;
      errors["Email"] = "Please enter your Email Address!";
    }

    if (typeof input["Email"] !== "undefined") {
      var pattern = new RegExp(
        /^(("[\w-\s]+")|([\w-]+(?:\.[\w-]+)*)|("[\w-\s]+")([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)/i
      );
      if (!pattern.test(input["Email"])) {
        isValid = false;
        errors["Email"] = "Please enter valid Email Address!";
      }
    }

    if (!input["Message"]) {
      isValid = false;
      errors["Message"] = "Please enter your Message!";
    }

    if (!input["Subject"]) {
      isValid = false;
      errors["Subject"] = "Please enter a Subject!";
    }

    this.setState({
      errors: errors,
    });

    return isValid;
  }
  render() {
    return (
      <Aux>
        <div id="contactus"></div>
        <div className="contactus container shadow-lg p-0  mb-5 bg-light rounded">
          <div className="row">
            <div className="col-md-6 piccon">
              <img src={Email} className="emailcontactus" alt="paper plane" />
            </div>
            <div className="col-md-6 detailscon text-center">
              <form>
                <h2>Contact Us</h2>
                <div className="text-danger">{this.state.errors.Name}</div>
                <div className="input-group mb-3">
                  <div className="input-group-prepend"></div>
                  <TextField
                    id="filled-basic Name"
                    label="Name"
                    name="Name"
                    variant="outlined"
                    className="form-control lblHeader"
                    size="small"
                    required
                    color="secondary"
                    value={this.state.input.Name || ""}
                    onChange={this.handleChange("Name").bind(this)}
                  />
                </div>
                <div className="text-danger">{this.state.errors.Email}</div>
                <div className="input-group mb-3">
                  <div className="input-group-prepend"></div>
                  <TextField
                    id="filled-basic Email"
                    label="Email Address"
                    variant="outlined"
                    required
                    name="Email"
                    className="form-control lblHeader"
                    size="small"
                    color="secondary"
                    onChange={this.handleChange("Email").bind(this)}
                    value={this.state.input.Email || ""}
                  />
                </div>
                <div className="text-danger">{this.state.errors.Subject}</div>
                <div className="input-group mb-3">
                  <div className="input-group-prepend"></div>
                  <TextField
                    id="filled-basic Subject"
                    label="Subject"
                    required
                    name="Subject"
                    variant="outlined"
                    className="form-control lblHeader"
                    size="small"
                    color="secondary"
                    onChange={this.handleChange("Subject").bind(this)}
                    value={this.state.input.Subject || ""}
                  />
                </div>
                <div className="text-danger">{this.state.errors.Message}</div>
                <div className="input-group mb-3">
                  <div className="input-group-prepend"></div>
                  <TextField
                    id="standard-multiline-static Message"
                    label="Message"
                    multiline
                    required
                    name="Message"
                    variant="outlined"
                    className="form-control lblHeader"
                    size="small"
                    rowsMax={3}
                    color="secondary"
                    value={this.state.input.Message || ""}
                    onChange={this.handleChange("Message").bind(this)}
                  />
                </div>

                <button
                  type="submit"
                  value="submit"
                  className="btn btn-dark btnsendemail btn-rounded"
                  onClick={this.handleSubmit}
                >
                  Send Email
                  <img src={Arrow} className="sendemailimage" alt="arrow" />
                </button>
              </form>
            </div>
          </div>
        </div>
      </Aux>
    );
  }
}

export default ContactUs;
