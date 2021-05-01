const express = require("express");
const morgan = require("morgan");
const helmet = require("helmet");

//const errMW = require("./middleware/error");

const userRouter = require("./routers/user");
const ticketRouter = require("./routers/ticket");
const dbRouter = require("./routers/db");

require("dotenv").config({ path: __dirname + "/../.env" });
const port = process.env.PORT || 9999;
const con = require("./db/db.js");
const app = express();


app.use(morgan("dev"));
app.use(helmet());
app.use(express.json());
//app.use(errMW());
app.use(userRouter);
app.use(ticketRouter);
app.use(dbRouter);

app.get("/", (req, res, next) => {
    try {
      //throw new Error("Error");
      res.json({
        success: "true",
        message: `Welcome to premier service solutions internal API`,
        data: {},
      });
    } catch (error) {
      next(error);
    }
  });

//Error
app.use((error, req, res, next) => {
    if (error.status) {
      res.status(error.status);
    } else {
      res.status(500);
    }
    const stack = process.env.NODE_ENV === "production" ? error.stack : "🌌";
    res.json({
      message: error.message,
      stack,
    });
});
  
app.listen(port, () => {
    console.log(`Listening on http://localhost:${port}`);
});