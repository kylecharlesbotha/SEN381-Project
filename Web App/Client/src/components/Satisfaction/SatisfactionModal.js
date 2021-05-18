import React, { useEffect, useState } from "react";
import { makeStyles } from "@material-ui/core/styles";
import { colors } from "@material-ui/core";
import StarBox from "./StarBox";
import axios from "axios";
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
		zIndex: "100",
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
		zIndex: "200",
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
		zIndex: "1000",
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
const SatisfactionModal = ({ showModal, setShowModal, satisfactionOBJ }) => {
	const [error, setError] = useState([]);
	const [ticket, setTicket] = useState([]);
	const [client, setClient] = useState([]);
	useEffect(() => {
		const config = {
			headers: {
				"Content-Type": "application/json",
				Authorization: `Bearer ${localStorage.getItem("authToken")}`,
			},
		};
		try {
			axios
				.post(
					"http://41.1.77.120:3001/api/private/data/ticket",
					{ TicketID: satisfactionOBJ.TicketID },
					config,
				)
				.then((res) => {
					setTicket(res.data.data.recordset[0]);
					axios
						.post(
							"http://41.1.77.120:3001/api/private/data/client",
							{ ClientID: res.data.data.recordset[0].ClientID },
							config,
						)
						.then((resClient) => {
							console.dir(resClient.data.data);
							setClient(resClient.data.data);
						});
				});
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
							<div className="container">
								<div className="row">
									<div className={`col-md-6  ${classes.satisfcationDetails}`}>
										<h3 className={`${classes.headings}`}>
											Satisfcation Details
										</h3>

										<p className={`${classes.ratings}`}>
											SatisfactionID: {satisfactionOBJ.SatisfactionID}
										</p>
										<p className={`${classes.ratings}`}>
											Service rating:{" "}
											<StarBox rating={satisfactionOBJ.ServiceRating} />
										</p>
										<p className={`${classes.ratings}`}>
											Technician rating:{" "}
											<StarBox rating={satisfactionOBJ.TechnicianRating} />
										</p>
										<p className={`${classes.ratings}`}>
											Quality rating:{" "}
											<StarBox rating={satisfactionOBJ.QualityRating} />
										</p>
										<p className={`${classes.ratings}`}>
											Overall rating:{" "}
											<StarBox rating={Math.round((satisfactionOBJ.ServiceRating + satisfactionOBJ.TechnicianRating + satisfactionOBJ.QualityRating)/3)} />
										</p>
										<p className={`${classes.ratings}`}>
											Overall rating: {satisfactionOBJ.Message}
										</p>
									</div>
									<div className={`col-md-6 ${classes.ticketDetails}`}>
										<h3 className={`${classes.headings}`}>Ticket Details</h3>
										<p className={`${classes.ticketText}`}>
											Title: {ticket.TicketTitle}
										</p>
										<p className={`${classes.ticketText}`}>
											Date Created: {ticket.TicketDateCreated}
										</p>
										<p className={`${classes.ticketText}`}>
											Due Date: {ticket.TicketDueDate}
										</p>
										<p className={`${classes.ticketText}`}>
											Issue Type: {ticket.TicketIssueType}
										</p>
										<p className={`${classes.ticketText}`}>
											Priority: {ticket.TicketPriority}
										</p>
										<p className={`${classes.ticketText}`}>
											Status: {ticket.TicketStatus}
										</p>
									</div>
								</div>
								<div className="row">
									<div className={`col-md-6 ${classes.clientDetails}`}>
										<h3 className={`${classes.headings}`}>Client Details</h3>
										<p className={`${classes.clientText}`}>
											ID: {client.ClientID}
										</p>
										<p className={`${classes.clientText}`}>
											Name: {client.ClientName}
										</p>
										<p className={`${classes.clientText}`}>
											Surname: {client.ClientSurname}
										</p>
										<p className={`${classes.clientText}`}>
											Title: {client.ClientTitle}
										</p>
										
										<p className={`${classes.clientText}`}>
											Address: {client.ClientAddress}
										</p>
									</div>
									<div className={`col-md-6 ${classes.contactClient}`}>
										<h3 className={`${classes.headings}`}>Contact Client</h3>
										<a  className={`${classes.clientText}`} href ={`mailto: ${client.ClientEmail}`}>Email: {client.ClientEmail}</a>
										<p className={`${classes.clientText}`} >Cell: {client.ClientCell}</p>
									</div>
								</div>
							</div>
							
						</div>
						
					</div>
				</div>
			) : null}
		</>
	);
};
export default SatisfactionModal;
