import React, {useState} from "react";
import Aux from "../../hoc/Auxillary";
import StarBox from "./StarBox";
import { Box, colors } from "@material-ui/core";
import { makeStyles } from "@material-ui/core/styles";
import SatisfactionPic from "../../assets/images/Satisfaction.png";
import Fade from 'react-reveal/Fade';
import SatisfactionModal from './SatisfactionModal';
const useStyles = makeStyles((theme) => ({
	mainContainer: {
		width: "500px",
		padding: "0px",
		maxHeight: "65px",
		
	},
	def: {
		margin: "0px",
		padding: "0px",
		maxHeight: "65px",
		maxWidth: "200px"
	},
	satisfaction: {
		margin: "0px",
		padding: "0px",
		height: "65px",
		minWidth: "500px",
		maxWidth: "500px",
		maxHeight: "65px"
	},
	leftSatisfactionBorder: {
		width: "10px",
		height: "65px",
		backgroundColor: colors.red[500],
		display: "inline-block",
	},
	satisfactionImg: {
		width: "70px",
		height: "65px",
		//backgroundColor: colors.red[200],
		display: "inline-block",
		paddingLeft: "25px",
		paddingTop: "6px",
	},
	textContent: {
		width: "400px",
		height: "65px",
		//backgroundColor: colors.red[100],
		display: "inline-block",
		float: "right",
		maxHeight: "65px" 
	},
	satisfactionText: {
		fontFamily: "Inter",
		fontStyle: "normal",
		//fontSize: "17px",
		// /fontHeight: "10px",

		textAlign: "left",
		letterSpacing: "-0.09em",
		textTransform: "lowercase",
		color: "black",
		height: "18px",
		paddingLeft: "11px",
	},
	logoimg: {
		display: "block",
		maxWidth: "100%",
		maxHeight: "100%",
		width: "auto",
		height: "auto",
	},
	row : {
		minWidth: "600px"
	}
}));
const Satisfaction = (props) => {
	const [showModal, setShowModal] = useState(false); 
	const openModal = () => {
		setShowModal(prev => !prev); 
	}
	const classes = useStyles();
	return (
		<Aux>
			<Fade left>
			<div onClick={openModal} className={`container shadow-sm mt-2 mb-2 ${classes.mainContainer}`}>
				<div className={`row`}>
					<div className={`col-md-4 ${classes.satisfaction}`}>
						<div className={`${classes.leftSatisfactionBorder}`}></div>
						<div className={`${classes.satisfactionImg}`}>
							<img
								src={SatisfactionPic}
								alt="logo"
								className={`${classes.logoimg}`}
							/>
						</div>
						<div className={`${classes.textContent}`}>
							<div className={`row ${classes.row}`}>
								<div className={`col-md-6 ${classes.def}`}>
									<p
										className={`${classes.satisfactionText}`}
										style={{ height: "3px" }}
									>
										service rating: <StarBox rating={props.serviceRating} />
									</p>
								</div>
								<div className={`col-md-6 ${classes.def}`}>
									<p
										className={`${classes.satisfactionText}`}
										style={{ height: "1px" }}
									>
										technician rating: <StarBox rating={props.technicianRating} />
									</p>
								</div>
							</div>
							<div className={`row`}>
								<div className={`col-md-6 ${classes.def}`}>
									<p
										className={`${classes.satisfactionText}`}
										style={{ height: "3px" }}
									>
										quality rating: <StarBox rating={props.qualityRating} />
									</p>
								</div>
								<div className={`col-md-6 ${classes.def}`}>
									<p
										className={`${classes.satisfactionText}`}
										style={{ height: "3px" }}
									>
										overall rating: <StarBox rating={Math.round((props.serviceRating + props.technicianRating + props.qualityRating)/3)} />
									</p>
								</div>
								
							</div>
							<div className={`row`}>
								<p
									className={`${classes.satisfactionText}`}
									style={{ height: "4px" }}
								>
									comment: {props.comment}
								</p>
							</div>
						</div>
					</div>
				</div>
			</div>
			</Fade>
			<SatisfactionModal showModal={showModal} setShowModal={setShowModal} satisfactionOBJ={props.satisfactionOBJ}/>
		</Aux>
	);
};

export default Satisfaction;
