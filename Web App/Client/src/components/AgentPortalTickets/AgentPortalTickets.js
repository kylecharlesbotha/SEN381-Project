import React, { useEffect, useState } from 'react';
import Aux from "../../hoc/Auxillary";
import Ticket from "../Ticket/Ticket"
import axios from "axios";
import { makeStyles } from '@material-ui/core/styles';
import { colors } from "@material-ui/core";

const useStyles = makeStyles((theme) => ({
    root: {
      '& > *': {
        margin: theme.spacing(1),
        width: '100%',
       // backgroundColor: colors.blue[100],
      }
    },
    mainDashboardContainer: {
        margin: "0px",
        width: '100%',
        height: "100vh",
        //backgroundColor: colors.blue[100],
    },mainContainer: {
       
    }
  }));
const TicketsPage = (props) => {
    const [tickets, setTickets] = useState([]);
    const [error, setError] = useState([]);
    const truncate = (string) => {
        return string.length > 48 ? string.substring(0, 45) + "..." : string;  
    }
    useEffect(()=>{
        const config = {
            headers: {
                "Content-Type": "application/json",
                Authorization: `Bearer ${localStorage.getItem("authToken")}`,
            },
        };
        try { 
            axios.get(
                "http://41.1.77.120:3001/api/private/data/tickets",
                config
            ).then(res => {     
                setTickets(res.data.data.recordset);
            })
            
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
        <Aux>
            {/* //<Ticket title={ticket.TicketTitle} priority={ticket.TicketPriority} description={ticket.TicketDescription}/> */}
            
            <div className={`container mt-4 `}>
                <div className={`row justify-content-center ${classes.mainContainer}`}>
                {tickets.map(ticket => (
                    <div key={ticket.TicketID} className={`col-md-5 ${classes.ticketsColumn}`}>
                        <div>                                       
                            <Ticket key={ticket.TicketID} title={ticket.TicketTitle} priority={ticket.TicketPriority} description={truncate(ticket.TicketDescription)}/>     
                                    
                        </div>  
                                
                    </div>
                    ))}
                </div>
            </div>
        </Aux>
    );
  };
export default TicketsPage;    