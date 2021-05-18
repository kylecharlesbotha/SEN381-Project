import React, { Component } from "react";
import { BrowserRouter, Route, Redirect, Switch } from "react-router-dom";
import Aux from "../hoc/Auxillary";
import AgentPortal from "../components/AgentPortal/AgentPortal";
import ClientPortal from "../components/ClientPortal/ClientPortal";
import ClientPortalDashboard from "../components/ClientPortalDashboard/ClientPortalDashboard";
import Feedback from "../components/ClientPortalDashboard/Feedback/Feedback";
import Home from "../components/Home/Home";
import "font-awesome/css/font-awesome.min.css";
import AgentPortalPrivateRoute from "../components/Routes/AgentPortalPrivateRoute";
import ClientPortalPrivateRoute from "../components/Routes/ClientPortalPrivateRoute";
import AgentPortalPrivateScreen from "../components/Screens/AgentPortalPrivateScreen";
import ClientPortalPrivateScreen from "../components/Screens/ClientPortalPrivateScreen";
import ForgotPassword from "../components/Password/Forgot/Forgot";
import ResetPassword from "../components/Password/Reset/Reset";
class Layout extends Component {
  render() {
    return (
      <BrowserRouter>
        <Aux>
          <Switch>
            <Redirect exact from="/" to="/Home" />
            
            <AgentPortalPrivateRoute
              exact
              path="/AgentPortal/Tickets"
              component={AgentPortalPrivateScreen}
            />
            <ClientPortalPrivateRoute
              exact
              path="/ClientPortal/Tickets"
              component={ClientPortalPrivateScreen}
            />
            <Route path="/Home" component={Home} />
            <Route path="/AgentPortal" component={AgentPortal} />
            <Route path="/ClientPortal" component={ClientPortal} />
            
            <Route path="/Password/Forgot/Email" component={ForgotPassword} />
            <Route path="/Password/Reset/:resetToken" component={ResetPassword} />
            <Route path="/Feedback" component={Feedback} />
          </Switch>
        </Aux>
      </BrowserRouter>
    );
  }
}

export default Layout;
