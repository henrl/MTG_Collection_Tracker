import axios from 'axios';

export class ApiHelper {
    constructor() {
        // TODO: change this so it is configurable and not hardcoded
        this.baseUrl = 'https://localhost:5001';
    }

    getCardsViaSearch(searchString){
        return axios.get(this.baseUrl + '/api/cards', {
            params: {
                Search: {
                    SearchString: searchString
                }
            }
        })
        .then(response => {
            return response.data;
        })
        .catch(e => {
            console.log(e);
        });
    }
}