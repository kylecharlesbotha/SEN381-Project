import React, {useState} from "react";
import Aux from "../../hoc/Auxillary";
import { makeStyles } from '@material-ui/core/styles';
import TicketPic from "../../assets/images/Ticket.png"
import { Box, colors } from "@material-ui/core";
import Fade from 'react-reveal/Fade';
import ClientTicketModal from "./ClientTicketModal";
const useStyles = makeStyles((theme) => ({
    
    mainContainer: {
        width: "500px"   ,
        padding: "0px"
    },
    ticket:{
        margin: "0px",
        padding: "0px",
        height: "65px",
        minWidth: "500px",
        maxWidth: "500px"
    },
    leftTicketBorder: {
        width: "10px", 
        height: "65px",
        backgroundColor: colors.red[500],
        display: "inline-block"
    },
    ticketImg: {
        width: "70px", 
        height: "65px",
        //backgroundColor: colors.red[200],
        display: "inline-block",
        paddingLeft: "14px", 
        paddingTop: "6px", 
        
    },
    textContent: {
        width: "400px",
        height: "65px",
        //backgroundColor: colors.red[100],
        display: "inline-block",
        float: "right"
    },
    ticketText: {
        fontFamily: "Inter", 
        fontStyle: "normal",
        fontSize: "17px",
        fontHeight: "10px",
        
        textAlign: "left",
        letterSpacing : "-0.09em",
        textTransform: "lowercase",
        color: "black",
        height: "18px",
        paddingLeft: "11px"

            
    },
    logoimg : {
        display: "block",
        maxWidth: "100%",
        maxHeight: "100%",
        width: "auto",
        height: "auto",
    },ticketTitleHeading:{
       color: "#A9A9A9"
    },ticketPriorityHeading: {
        color: "#A9A9A9"
    },ticketDescriptionHeading: {
        color: "#A9A9A9"
    },ticketTitleText:{
         fontWeight: "medium",
         color: "black",

     },ticketPriorityText: {
         fontWeight: "medium",
         color: "black"
     },ticketDescriptionText: {
         color: "black",
         fontWeight: "medium",
         wordWrap: "break-word"
     } 
  }));
const Ticket = (props) => {
    const [showModal, setShowModal] = useState(false); 
	const openModal = () => {
		setShowModal(prev => !prev); 
	}
    const classes = useStyles();
    return (
        <Aux>
            <Fade bottom>
            <div  onClick={openModal} className={`container shadow-sm mt-2 mb-2 ${classes.mainContainer}`}>
                <div className={`row`}>
                    <div className={`col-md-4 ${classes.ticket}`}>
                        <div className={`${classes.leftTicketBorder}`}>

                        </div>
                        <div className={`${classes.ticketImg}`}>            
                            <img src={TicketPic} alt="logo" className={`${classes.logoimg}`}/>     
                        </div>
                        <div className={`${classes.textContent}`}>
                            <div className={`row ${classes.ticketTitle} ${classes.ticketText}`}>
                                <p><span className={`${classes.ticketTitleHeading}`}>Title: </span><span className={`${classes.ticketTitleText}`}>{props.title}</span></p>
                                
                            </div>
                            <div className={`row ${classes.ticketPriority} ${classes.ticketText}`}>
                                <p><span className={`${classes.ticketPriorityHeading}`}>Priority: </span><span className={`${classes.ticketPriorityText}`}>{props.priority}</span></p>
                                
                            </div>
                            <div className={`row ${classes.ticketDescription} ${classes.ticketText}`}>
                                <p><span className={`${classes.ticketDescriptionHeading}`}>Description: </span><span className={`${classes.ticketDescriptionText}`}>{props.description}</span></p>
                            </div>
                        </div>
                    </div>
                    
                </div>
            </div>
            </Fade>
            <ClientTicketModal showModal={showModal} setShowModal={setShowModal} ticketID={props.id}/>
        </Aux>
    )
}

export default Ticket; 