import React from "react"; 
import Aux from "../../hoc/Auxillary"
import { makeStyles } from '@material-ui/core/styles';

import BlankStar from "../../assets/images/BigTest.png";
import RedStar from "../../assets/images/RedStarBig.png";
import GreenStar from "../../assets/images/GreenStarBig.png";
import OrangeStar from "../../assets/images/OrangeStarBig.png";
const useStyles = makeStyles((theme) => ({
    
    row: {
       display: "flex",
       display: "inline-block",
       padding: "0px",    
       margin: "0px",
       height: "20px"  
    },
    col: {
        float: "left",
        flex: 1, 
        padding: "0px", 
        margin: "0px",
        height: "20px"  
    },
    star: {
        padding: "0px",  
        margin: "0px",   
        height: "15px"    
    }
  }));
const StarBox = (props) => {
    const stars = [];
    const rating = parseInt(props.rating); 
    let star = BlankStar; 

    switch(rating) {
        case 1:
          star = RedStar;         
          break;
        case 2:
            star = RedStar
            break;
        case 3:
            star = OrangeStar;
            break;
        case 4:
            star = OrangeStar;        
            break;
        case 5:
            star = GreenStar; 
            break;
        default:
            star = BlankStar;
    }

    for (let i = 1; i < 6; i++) {
        if (rating >= i){
            stars.push(star);
        }else{
            stars.push(BlankStar);
        }
         
    }

    const classes = useStyles();
    return(
    <Aux>
        <div className={`${classes.row}`}>
            {stars.map(element => (
                <div className={`${classes.col}`}>
                    <img src={element} alt="logo" className={`${classes.star}`}/>     
                </div>
            ))}   
        </div>
    </Aux>
    )
    
}

export default StarBox; 