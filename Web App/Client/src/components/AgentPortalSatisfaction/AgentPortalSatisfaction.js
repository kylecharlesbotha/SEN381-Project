import React, { useEffect, useState } from 'react';
import Aux from "../../hoc/Auxillary";
import Satisfaction from "../Satisfaction/Satisfaction";
import { colors } from "@material-ui/core";
const SatisfactionPage = (props) => {
    return (
        <Aux>          
            <Satisfaction/>
        </Aux>
    );
  };
export default SatisfactionPage;    