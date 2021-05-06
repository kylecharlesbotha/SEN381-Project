import React from "react";
import Aux from "../../hoc/Auxillary";
import StarBox from "./StarBox";
import { Box, colors } from "@material-ui/core";
import { makeStyles } from "@material-ui/core/styles";
import SatisfactionPic from "../../assets/images/Satisfaction.png";
const useStyles = makeStyles((theme) => ({
	mainContainer: {
		width: "500px",
		padding: "0px",
	},
	def: {
		margin: "0px",
		padding: "0px",
	},
	satisfaction: {
		margin: "0px",
		padding: "0px",
		height: "65px",
		minWidth: "500px",
		maxWidth: "500px",
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
		backgroundColor: colors.red[200],
		display: "inline-block",
		paddingLeft: "14px",
		paddingTop: "6px",
	},
	textContent: {
		width: "400px",
		height: "65px",
		//backgroundColor: colors.red[100],
		display: "inline-block",
		float: "right",
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
}));
const Satisfaction = (props) => {
	const classes = useStyles();
	return (
		<Aux>
			<div className={`container shadow-sm mt-2 mb-2 ${classes.mainContainer}`}>
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
							<div className={`row`}>
								<div className={`col-md-6 ${classes.def}`}>
									<p
										className={`${classes.satisfactionText}`}
										style={{ height: "3px" }}
									>
										service rating: <StarBox rating="5" />
									</p>
								</div>
								<div className={`col-md-6 ${classes.def}`}>
									<p
										className={`${classes.satisfactionText}`}
										style={{ height: "1px" }}
									>
										avg. rating: <StarBox rating="5" />
									</p>
								</div>
							</div>
							<div className={`row`}>
								<p
									className={`${classes.satisfactionText}`}
									style={{ height: "3px" }}
								>
									support rating: <StarBox rating="3" />
								</p>
							</div>
							<div className={`row`}>
								<p
									className={`${classes.satisfactionText}`}
									style={{ height: "4px" }}
								>
									comment: lorem ipsum this is too ez for me ekse...
								</p>
							</div>
						</div>
					</div>
				</div>
			</div>
		</Aux>
	);
};

export default Satisfaction;
