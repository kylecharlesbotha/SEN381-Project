import React, { useEffect, useState } from "react";
import { makeStyles } from "@material-ui/core/styles";
import { colors } from "@material-ui/core";
import axios from "axios";
import Feedback from "../ClientPortalDashboard/Feedback/Feedback"
const useStyles = makeStyles((theme) => ({
	background: {
		width: "100vw",
		height: "100vh",
		padding: "0px",
		margin: "0px",
		background: "rgba(0,0,0,0.8)",
		position: "absolute",
		left: "0px",
		top: "0px",
		display: "flex",
		justifyContent: "center",
		alignItems: "center",
		zIndex: "1",
	},
	modalWrapper: {
		width: "90vw",
		height: "80vh",
		overflow: "auto",
		boxShadow: "0 5px 16px rgba(0,0,0,0.1)",
		background: "#fff",
		display: "grid",
		gridTemplateColumns: "1fr",
		position: "relative",
		zIndex: "10",
		borderRadius: "10px",
		//backgroundColor: colors.blue[200],
	},
	modalImg: {
		width: "100%",
		height: "100%",
		borderRadius: "10px 0 0 10px",
		background: "#fff",
	},
	modalContent: {
		display: "flex",
		flexDirection: "column",
		justifyContent: "center",
		alignItems: "center",
		lineHeight: "1.8",
		color: "#141414",
	},
	p: {
		marginBottom: "1rem",
	},
	button: {
		padding: "10px 24px",
		background: "#141414",
		color: "#fff",
		border: "none",
	},
	satisfcationDetails: {
		//backgroundColor: colors.blue[100],

		height: "250px",
	},
	ticketDetails: {
		//	backgroundColor: colors.blue[200],
		height: "250px",
	},
	clientDetails: {
		//	backgroundColor: colors.blue[400],
		height: "250px",
	},
	contactClient: {
		//	backgroundColor: colors.blue[300],
		height: "250px",
	},
	ratings: {
		fontFamily: "Inter",
		fontStyle: "normal",
		//fontSize: "17px",
		// /fontHeight: "10px",
		marginLeft: "0px",
		paddingLeft: "0px",
		textAlign: "left",
		letterSpacing: "-0.09em",
		textTransform: "lowercase",
		color: "black",
		height: "18px",
		paddingLeft: "11px",
	},
	ticketText: {
		fontFamily: "Inter",
		fontStyle: "normal",
		//fontSize: "17px",
		// /fontHeight: "10px",
		marginLeft: "0px",
		paddingLeft: "0px",
		textAlign: "left",
		letterSpacing: "-0.09em",
		textTransform: "lowercase",
		color: "black",
		height: "18px",
		paddingLeft: "11px",
	},
	clientText: {
		fontFamily: "Inter",
		fontStyle: "normal",
		//fontSize: "17px",
		// /fontHeight: "10px",
		marginLeft: "0px",
		paddingLeft: "0px",
		textAlign: "left",
		letterSpacing: "-0.09em",
		color: "black",
		height: "13px",
		paddingLeft: "11px",
	},
	headings: {
		fontFamily: "Inter",
		fontStyle: "normal",
		//fontSize: "17px",
		// /fontHeight: "10px",
		marginLeft: "0px",
		paddingLeft: "0px",
		marginBottom: "15px",
		textAlign: "left",
		letterSpacing: "-0.09em",
		color: "black",
		height: "13px",
		paddingLeft: "11px",
		textDecoration: "underline",
		fontWeight: "500",
	},
	modalClose : {
		fontSize: "x-large",
		color: "white", 
		position: "absolute",
		top: "6%", 
		left: "50%",
		transform: "translate(-50%, -50%)"
	}
}));
const SatisfactionModal = ({ showModal, setShowModal, ticketID }) => {
	const [error, setError] = useState([]);
	
	
	useEffect(() => {
		const config = {
			headers: {
				"Content-Type": "application/json",
				Authorization: `Bearer ${localStorage.getItem("clientToken")}`,
			},
		};
		try {
			
		} catch (error) {
			console.dir(error);
			setError(error.response.data.error);
			setTimeout(() => {
				setError("");
			}, 5000);
		}
	}, []);
	const classes = useStyles();
	return (
		<>
			{showModal ? (
				<div className={`${classes.background}`}>
                    <i onClick={() => {
						setShowModal(prev => !prev);
					}} className={`fa fa-power-off ${classes.modalClose}`}/>
					<div className={`${classes.modalWrapper}`}>
						<div className={`${classes.modalContent}`}>
                            <Feedback ticketID={ticketID}/>
						</div>
					</div>
				</div>
			) : null}
		</>
	);
};
export default SatisfactionModal;
