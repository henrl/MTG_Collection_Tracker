import axios from 'axios';

export class ApiHelper {
    constructor() {
        // TODO: change this so it is configurable and not hardcoded
        this.baseUrl = 'https://localhost:5001';
    }

    async getCardsViaSearch(nameSearch) {
        let results = await axios({
            method: 'post',
            url: this.baseUrl + '/api/cards',
            data: {
                'searchString': nameSearch
            }
        })
        .then(response => {
            return response.data;
        })
        .catch(e => {
            console.log(e);
        });
        return results;
    }

    async updateCardQuantity(id, quantity) {
        let result = await axios({
            method: 'put',
            url: this.baseUrl + '/api/cards',
            data: {
                'id': id,
                'quantity': quantity
            }
        })
        .then(response => {
            return response.data;
        })
        .catch(e => {
            console.log(e);
        });
        return result;
    }
}