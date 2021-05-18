import { Redirect, Route, BrowserRouter as Router } from "react-router-dom";

const PrivateRoute = ({ component: Component, ...rest }) => {
	return (
		<Route
			{...rest}
			render={(props) =>
				localStorage.getItem("clientToken") ? (
					<Component {...props} />
				) : (
					<Redirect to="/ClientPortal" />
				)
			}
		></Route>
	);
};
export default PrivateRoute;
