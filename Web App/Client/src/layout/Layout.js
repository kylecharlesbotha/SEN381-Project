import React, { Component } from "react";
import { BrowserRouter, Route, Redirect, Switch } from "react-router-dom";
import Aux from "../hoc/Auxillary";
import AgentPortal from "../components/AgentPortal/AgentPortal";
import ClientPortal from "../components/ClientPortal/ClientPortal";
import Home from "../components/Home/Home";
import "font-awesome/css/font-awesome.min.css";

class Layout extends Component {
  render() {
    return (
      <BrowserRouter>
        <Aux>
          <Switch>
            <Redirect exact from="/" to="/Home" />
            <Route path="/Home" component={Home} />
            <Route path="/AgentPortal" component={AgentPortal} />
            <Route path="/ClientPortal" component={ClientPortal} />
          </Switch>
        </Aux>
      </BrowserRouter>
    );
  }
}

export default Layout;
