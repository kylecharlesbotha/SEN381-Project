import { useState, useEffect } from "react";
import axios from "axios";
import Dashboard from "../AgentPortalDashboard/AgentPortalDashboard";
import { NavLink } from "react-router-dom"; 
import Logo from "../../assets/images/PSSLogo.png";
import Aux from "../../hoc/Auxillary";
import Box from "@material-ui/core/Box";
const PrivateScreen = ({ history }) => {
	const [error, setError] = useState("");
	const [privateData, setPrivateData] = useState("");

	useEffect(() => {
		if (!localStorage.getItem("authToken")) {
			history.push("/AgentPortal");
		}

		const fetchPrivateData = async () => {
			const config = {
				headers: {
					"Content-Type": "application/json",
					Authorization: `Bearer ${localStorage.getItem("authToken")}`,
				},
			};
			try {
                console.log(config.headers.Authorization);
				const { data } = await axios.get("http://localhost:3001/api/private/", config);
                console.dir(data);
				setPrivateData(data.data);
			} catch (error) {
                console.dir(error);

				localStorage.removeItem("authToken");
				setError("Not authorized.");
			}
		};
		fetchPrivateData();
	}, [history]);
	const logoutHandler = () => {
		localStorage.removeItem("authToken");
		history.push("/AgentPortal");
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
				<nav className="navbar navbar-expand-lg navbar-light bg-light shadow-lg p-2 mb-2 bg-white rounded">
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
			</Aux>
		<Dashboard/>
		</>
	);
};

export default PrivateScreen;