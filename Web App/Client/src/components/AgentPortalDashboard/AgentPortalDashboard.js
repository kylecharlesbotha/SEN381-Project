import React from "react";
import Aux from "../../hoc/Auxillary";

import { makeStyles } from '@material-ui/core/styles';
import { colors } from "@material-ui/core";
const useStyles = makeStyles((theme) => ({
    root: {
      '& > *': {
        margin: theme.spacing(1),
        width: '100%',
       // backgroundColor: colors.blue[100],
      }
    },
    mainDashboardContainer: {
        margin: "0px",
        width: '100%',
       // backgroundColor: colors.blue[100],
    },leftPanel: {
       // backgroundColor: colors.blue[200],
        height: "100vh"
    },panelTitle: {
        //backgroundColor: colors.red[200],
    }
  }));
const menuItem = ["Dashboard", "Tickets", "Chats"]; 
const Dashboard = (props) => {
    const classes = useStyles();
    return (
        <Aux>
        <div className={`container-fluid ${classes.mainDashboardContainer}`}>
            <div className={`row`}>
                <div className={`col-md-2 shadow-md ${classes.leftPanel}`}>
                    <div className={`row text-center pt-4 pb-3 shadow-sm  ${classes.panelTitle}`}>
                        <h3>Dashboard</h3>
                    </div>
                </div>
                <div className={`col-md-9 offset-sm-1 shadow-lg ${classes.leftPanel}`}>
                    <h2>Welcome to the Agent Portal!</h2>
                </div>
            </div>
        </div>
    </Aux>
    );
  };
export default Dashboard;