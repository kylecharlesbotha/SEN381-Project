import { useState, useEffect } from "react";
import axios from "axios";
import ClientPortalDashboard from "../ClientPortalDashboard/ClientPortalDashboard";
import { NavLink } from "react-router-dom"; 
import Logo from "../../assets/images/PSSLogo.png";
import Aux from "../../hoc/Auxillary";
import Box from "@material-ui/core/Box";
import { BrowserRouter, Route, Redirect, Switch } from "react-router-dom";

const PrivateScreen = ({ history }) => {
	const [error, setError] = useState("");
	const [privateData, setPrivateData] = useState("");

	useEffect(() => {
		if (!localStorage.getItem("clientToken")) {
			history.push("/ClientPortal");
		}

		const fetchPrivateData = async () => {
			const config = {
				headers: {
					"Content-Type": "application/json",
					Authorization: `Bearer ${localStorage.getItem("clientToken")}`,
				},
			};
			try {           
				const { data } = await axios.get("http://41.1.77.120:3001/api/private/clientData", config);
				setPrivateData(data.data);
			} catch (error) {
                
				 
				localStorage.removeItem("clientToken");
				setError("Not authorized.");
			}
		};
		fetchPrivateData();
	}, [history]);
	const logoutHandler = () => {
		localStorage.removeItem("clientToken");
		history.push("/ClientPortal");
	};
	return error ? (
		<span className="error-message">{error}</span>
	) : (
		// <>
		// 	<div style={{ background: "green", color: "white" }}>{privateData}</div>
		// 	<Dashboard/>
		// 	<button onClick={logoutHandler}>Logout</button>
		// </>
		<>	
			<Aux>	
				<BrowserRouter>	
					
					<Switch>     
						<Route path="/ClientPortal/Tickets" component={ClientPortalDashboard} />
					</Switch>
      			</BrowserRouter>
			</Aux>
		</>
	);
};

export default PrivateScreen;