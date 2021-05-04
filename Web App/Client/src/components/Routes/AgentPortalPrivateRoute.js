import { Redirect, Route, BrowserRouter as Router } from "react-router-dom";

const PrivateRoute = ({ component: Component, ...rest }) => {
	return (
		<Route
			{...rest}
			render={(props) =>
				localStorage.getItem("authToken") ? (
					<Component {...props} />
				) : (
					<Redirect to="/AgentPortal" />
				)
			}
		></Route>
	);
};
export default PrivateRoute;
