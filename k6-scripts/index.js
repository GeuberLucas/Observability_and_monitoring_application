import { group } from "k6";
import GetAllPersonTest from "./GetAllPersons.js";
import InsertPersonTest from "./InsertPersons.js";
import GetByIdPersonTest from "./GetByIdPersons.js";

export const options = {
    stages: [
        { duration: '10s', target: 1 },
        { duration: '15s', target: 10 },
        { duration: '20s', target: 100 },
        { duration: '25s', target: 1000 },
        { duration: '30s', target: 10000 },
    ]
};

export default function () {
    const apiUrl = 'app';
    group('GetAllPersonTest', function () {
        GetAllPersonTest(apiUrl);
    });
    group('InsertPersonTest', function () {
        InsertPersonTest(apiUrl);
    });
    group('GetByIdPersonTest', function () {
        GetByIdPersonTest(apiUrl);
    });
}