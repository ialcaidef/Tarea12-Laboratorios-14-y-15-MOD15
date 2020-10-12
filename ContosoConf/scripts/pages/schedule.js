﻿import { LocalStarStorage } from "../LocalStarStorage.js";
import { ScheduleList } from "../ScheduleList.js";

const scheduleListElement = document.getElementById("schedule");
const scheduleList = new ScheduleList(
    scheduleListElement,
    new LocalStarStorage(localStorage)
);

scheduleList.startDownload();

