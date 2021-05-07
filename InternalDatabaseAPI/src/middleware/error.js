// module.exports = (error, req, res, next) => {
//     if (error.status) {
//       res.status(error.status);
//     } else {
//       res.status(500);
//     }
//     const stack = process.env.NODE_ENV === "production" ? error.stack : "🌌";
//     res.json({
//       message: error.message,
//       stack,
//     });
// }