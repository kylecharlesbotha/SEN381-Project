import React from "react";
import Aux from "../../../hoc/Auxillary";
import "./Feedback.css";
import { Box } from "@material-ui/core";
import TextField from "@material-ui/core/TextField";

import Radio from "@material-ui/core/Radio";
import RadioGroup from "@material-ui/core/RadioGroup";
import FormControlLabel from "@material-ui/core/FormControlLabel";
import FormControl from "@material-ui/core/FormControl";
import FormLabel from "@material-ui/core/FormLabel";

import Arrow from "../../../assets/images/arrow.png";

class Feedback extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      service: 1,
      technician: 1,
      quality: 1,
    };
  }

  handleServiceChange = (e) => {
    e.preventDefault();
    let { value } = e.target;
    this.state.service = value;
    console.log("service : " + value);
  };

  handleTechnicianChange = (e) => {
    e.preventDefault();
    let { value } = e.target;
    this.state.technician = value;
    console.log("technician:" + value);
  };

  handleQualityChange = (e) => {
    e.preventDefault();
    let { value } = e.target;
    this.state.quality = value;
    console.log("quality:" + value);
  };
  render() {
    return (
      <Aux>
        <div className="container feedback">
          <div className="row justify-content-center">
            <div className="col-md-7  mt-2 HeadingSection">
              <h2>Ticket Feedback Form</h2>
              <p>
                Please feel free to rate our service so we can improve our
                day-to-day services
              </p>
            </div>

            <Box className="redDivider col-md-8"></Box>
            <div className="col-md-7 mt-3 OverallSection">
              <h4>Please rate our Overall Service</h4>
              <div>
                <div className="container justify-content-center">
                  <div className="row justify-content-center">
                    <FormControl
                      component="fieldset"
                      className="justify-content-center"
                    >
                      <RadioGroup
                        className="justify-content-center"
                        row
                        onChange={this.handleServiceChange}
                        aria-label="position"
                        name="position"
                        defaultValue="1"
                      >
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="1"
                            control={<Radio color="primary" />}
                            label="1"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="2"
                            control={<Radio color="primary" />}
                            label="2"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="3"
                            control={<Radio color="primary" />}
                            label="3"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="4"
                            control={<Radio color="primary" />}
                            label="4"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="5"
                            control={<Radio color="primary" />}
                            label="5"
                            labelPlacement="bottom"
                          />
                        </div>
                      </RadioGroup>
                    </FormControl>
                  </div>
                </div>
              </div>
            </div>

            <div className="col-md-7 mt-3 TecSection">
              <h4>Please rate the Technician Service</h4>
              <div>
                <div className="container justify-content-center">
                  <div className="row justify-content-center">
                    <FormControl
                      component="fieldset"
                      className="justify-content-center"
                    >
                      <RadioGroup
                        className="justify-content-center"
                        row
                        onChange={this.handleTechnicianChange}
                        aria-label="position"
                        name="position"
                        defaultValue="1"
                      >
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="1"
                            control={<Radio color="primary" />}
                            label="1"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="2"
                            control={<Radio color="primary" />}
                            label="2"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="3"
                            control={<Radio color="primary" />}
                            label="3"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="4"
                            control={<Radio color="primary" />}
                            label="4"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="5"
                            control={<Radio color="primary" />}
                            label="5"
                            labelPlacement="bottom"
                          />
                        </div>
                      </RadioGroup>
                    </FormControl>
                  </div>
                </div>
              </div>
            </div>

            <div className="col-md-7 mt-3 QualitySection justify-content-center">
              <h4>Please rate the level of Quality Recieved</h4>
              <div>
                <div className="container justify-content-center">
                  <div className="row justify-content-center">
                    <FormControl
                      component="fieldset"
                      className="justify-content-center"
                    >
                      <RadioGroup
                        className="justify-content-center"
                        row
                        onChange={this.handleQualityChange}
                        aria-label="position"
                        name="position"
                        defaultValue="1"
                      >
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="1"
                            control={<Radio color="primary" />}
                            label="1"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="2"
                            control={<Radio color="primary" />}
                            label="2"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="3"
                            control={<Radio color="primary" />}
                            label="3"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="4"
                            control={<Radio color="primary" />}
                            label="4"
                            labelPlacement="bottom"
                          />
                        </div>
                        <div className="col-md-2 justify-content-center text-center">
                          <FormControlLabel
                            className="test"
                            value="5"
                            control={<Radio color="primary" />}
                            label="5"
                            labelPlacement="bottom"
                          />
                        </div>
                      </RadioGroup>
                    </FormControl>
                  </div>
                </div>
              </div>
            </div>
            <Box className="redDivider col-md-7 mt-3"></Box>
            <div className="col-md-7 mt-3 CommentSection">
              <h4>Please provide a comment</h4>
              <TextField
                id="standard-multiline-static Message"
                label="Comment"
                multiline
                required
                name="Message"
                variant="outlined"
                className="form-control lblHeader"
                size="small"
                rowsMax={3}
                color="secondary"
              />
            </div>
            <Box className="redDivider col-md-7 mt-3 "></Box>
            <div className="col-md-7 mt-3 ButtonSection text-center">
              <button
                type="submit"
                value="submit"
                className="btn btn-dark btnsendfeedback btn-rounded"
                onClick={this.handleSubmit}
              >
                Submit Feed Back
                <img src={Arrow} className="sendfeedbackimage" alt="arrow" />
              </button>
            </div>
          </div>
        </div>
      </Aux>
    );
  }
}

export default Feedback;
