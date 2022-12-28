import express from "express";
import { pool } from "./db.js";
import employeesRoutes from "./routes/employees.routes.js";
import indexRoutes from "./routes/index.routes.js";

const app = express();

app.use(employeesRoutes);
app.use(indexRoutes);

app.listen(3000);
console.log("Listening on port");
