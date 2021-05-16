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
		if (!localStorage.getItem("authToken")) {
			history.push("/ClientPortal");
		}

		const fetchPrivateData = async () => {
			const config = {
				headers: {
					"Content-Type": "application/json",
					Authorization: `Bearer ${localStorage.getItem("authToken")}`,
				},
			};
			try {           
				const { data } = await axios.get("http://41.1.129.59:3001/api/private/clientData", config);
				setPrivateData(data.data);
			} catch (error) {
                

				localStorage.removeItem("authToken");
				setError("Not authorized.");
			}
		};
		fetchPrivateData();
	}, [history]);
	const logoutHandler = () => {
		localStorage.removeItem("authToken");
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
				<nav className="navbar navbar-expand-lg navbar-light bg-light shadow-sm p-2 mb-0 bg-white rounded">
					<div className="container-fluid">
						<img src={Logo} alt="Logo" className="logoimg" />
						<button
						className="navbar-toggler"
						type="button"
						data-bs-toggle="collapse"
						data-bs-target="#navbarNav"
						>
						<i className="fa fa-bars"></i>
						</button>
						<div className="collapse navbar-collapse" id="navbarNav">
						<ul className="navbar-nav">
								<li fontWeight="fontWeightBold" className="nav-item">
									<Box fontWeight="fontWeightBold" m={1}>
										<NavLink className="nav-link active" aria-current="page" to="/AgentPortal/Dashboard">
											Dashboard
										</NavLink>
									</Box>
								</li>
								<li fontWeight="fontWeightBold" className="nav-item">
									<Box fontWeight="fontWeightBold" m={1}>
										<NavLink className="nav-link active" aria-current="page" to="/AgentPortal/Chat">
											Chat
										</NavLink>
									</Box>
								</li>
							</ul>
							<ul className="navbar-nav ms-auto">
								<li fontWeight="fontWeightBold" className="nav-item">
									<Box fontWeight="fontWeightBold" m={1}>
										<a className="nav-link active" aria-current="page" href="/">
											Exit portal
										</a>
									</Box>
								</li>
								<li fontWeight="fontWeightBold" className="nav-item">
									<Box fontWeight="fontWeightBold" m={1}>
										<a className="nav-link active" aria-current="page" href="/AgentPortal" onClick={logoutHandler}>
											Logout
										</a>
									</Box>
								</li>
							</ul>
						</div>
					</div>
				</nav>		
					<Switch>     
						<Route path="/ClientPortal/Dashboard" component={AgentPortalDashboard} />
					</Switch>
      			</BrowserRouter>
			</Aux>
		</>
	);
};

export default PrivateScreen;