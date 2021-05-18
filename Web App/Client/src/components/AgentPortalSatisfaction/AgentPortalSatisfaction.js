import React, { useEffect, useState } from 'react';
import Aux from "../../hoc/Auxillary";
import Satisfaction from "../Satisfaction/Satisfaction";
import { colors } from "@material-ui/core";
import axios from "axios";
import { makeStyles } from '@material-ui/core/styles';
const useStyles = makeStyles((theme) => ({
    root: {
      '& > *': {
        
    
       // backgroundColor: colors.blue[100],
      }
    },
    mainDashboardContainer: {
       
      
        //backgroundColor: colors.blue[100],
    },mainContainer: {
       
    },
    ticketsColumn: {
        marginLeft: "40px",
        marginRight: "40px"
    }
  }));
const SatisfactionPage = (props) => {
    const [satisfactions, setSatisfactions] = useState([]);
    const [error, setError] = useState([]);
    const truncate = (string) => {
        return string.length > 50 ? string.substring(0, 47) + "..." : string;  
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
                "http://premierservicesolutions.flystudio.co.za:3001/api/private/data/satisfactions",
                config
            ).then(res => {
                console.dir(res.data.data.recordset); 
                setSatisfactions(res.data.data.recordset);
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
                {satisfactions.map(satisfaction => (
                    <div key={satisfaction.SatisfactionID} className={`col-md-5 ${classes.ticketsColumn}`}>
                        <div>                                       
                            <Satisfaction key={satisfaction.SatisfactionID} serviceRating={satisfaction.ServiceRating} technicianRating={satisfaction.TechnicianRating} qualityRating={satisfaction.QualityRating} comment={truncate(satisfaction.Message)} satisfactionOBJ={satisfaction}/>     
                        </div>  
                    </div>
                    ))}
                </div>
            </div>
        </Aux>
    );
  };
export default SatisfactionPage;    