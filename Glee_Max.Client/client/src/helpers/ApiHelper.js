import axios from 'axios';

export default class ApiHelper {
    constructor() {
        // TODO: change this so it is configurable and not hardcoded
        this.baseUrl = 'https://localhost:5001';
    }

    async static getAllCards(){
        return axios.get(this.baseUrl + '/api/cards')
        .then(response => {
            return response.data;
        })
        .catch(e => {
            console.log(e);
        });
    }
};