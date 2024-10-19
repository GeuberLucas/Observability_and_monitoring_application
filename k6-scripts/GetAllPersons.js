import http from "k6/http";

 
export default function GetAllPersonTest(apiUrl){
    http.get(`http://${apiUrl}/api/Register/GetAll`,{
        headers: {
            'Content-Type': 'application/json',
        },
    });
}