﻿import { LivePage } from "../LivePage.js";
// TODO: Create a web socket connection to ws://localhost:55981/live/socket.ashx
const socket = new WebSocket("ws://localhost:55981/live/socket.ashx");
new LivePage(
    socket,
    document.querySelector("section.live")
);
