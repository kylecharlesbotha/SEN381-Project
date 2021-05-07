import React from "react";
import Aux from "../../../hoc/Auxillary";
import "./Feedback.css";
import { Box } from "@material-ui/core";
import Typography from "@material-ui/core/Typography";
import Slider from "@material-ui/core/Slider";

const marks = [
  {
    value: 0,
    label: "0",
  },
  {
    value: 1,
    label: "1",
  },
  {
    value: 2,
    label: "2",
  },
  {
    value: 3,
    label: "3",
  },
  {
    value: 4,
    label: "4",
  },
  {
    value: 5,
    label: "5",
  },
  {
    value: 6,
    label: "6",
  },
  {
    value: 7,
    label: "7",
  },
  {
    value: 8,
    label: "8",
  },
  {
    value: 9,
    label: "9",
  },
  {
    value: 10,
    label: "10",
  },
];


class Feedback extends React.Component {

  constructor(props) {
    super(props);
    this.state = {
        value: 0
    };
}

onChange(e) {
  const newVal = (e.target.value);
  this.setState({value: newVal});
  console.log(newVal)
}

  render() {
    return (
      <Aux>
        <p>Feedback</p>
        <div className="container feedback">
          <div className="row shadow-lg p-0 mb-5 bg-light rounded justify-content-center">
            <div className="col-md-10  mt-2 HeadingSection">
              <h2>Ticket Feedback Form</h2>
              <p>
                Please feel free to rate our service so we can improve our
                day-to-day services
              </p>
            </div>
            <Box className="redDivider col-md-11"></Box>
            <div className="col-md-10 mt-3 OverallSection">
              <h3>Please rate our Overall Service</h3>
              <div>
                <Typography id="discrete-slider-custom" gutterBottom>
                  Rate from 1 to 10. 1 Being Terrible and 10 Being Perfect
                </Typography>
                <Slider
                  defaultValue={0}
                  aria-labelledby="discrete-slider-custom"
                  step={1}
                  marks={marks}
                  max={10}
                />
              </div>
            </div>
            <Box className="blackDivider col-md-11"></Box>
            <div className="col-md-10 mt-3 TecSection">
              <h3>Please rate the Technician Service</h3>
              <div>
                <Typography id="discrete-slider-custom" gutterBottom>
                  Rate from 1 to 10. 1 Being Terrible and 10 Being Perfect
                </Typography>
                <Slider
                  defaultValue={0}
                  aria-labelledby="discrete-slider-custom"
                  step={1}
                  marks={marks}
                  max={10}
                />
              </div>
            </div>
            <Box className="blackDivider col-md-11"></Box>
            <div className="col-md-10 mt-3 QualitySection">
              <h3>Please rate the level of Quality Recieved</h3>
              <div>
                <Typography id="discrete-slider-custom" gutterBottom>
                  Rate from 1 to 10. 1 Being Terrible and 10 Being Perfect
                </Typography>
                <Slider
                  defaultValue={0}
                  aria-labelledby="discrete-slider-custom"
                  step={1}
                  max={10}
                  marks={marks}
                />
              </div>
            </div>
            <Box className="blackDivider col-md-11"></Box>
            <div className="col-md-10 mt-3 CommentSection">
              <p>Rate Quality of service</p>
            </div>
            <Box className="redDivider col-md-11"></Box>
            <div className="col-md-10 mt-3 ButtonSection">
              <p>Button Section</p>
            </div>
          </div>
        </div>
      </Aux>
    );
  }
}

export default Feedback;
