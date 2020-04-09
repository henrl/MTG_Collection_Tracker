<template>
    <div>
        <h4>{{ name }}</h4>
        <p v-if="commanderLegal === false"><strong>Not Commander Legal</strong></p>
        <p>{{ manaCost }} - (converted mana cost: {{ cmc }})</p>
        <p>{{ setName }}</p>
        <hr/>
        <p>{{ typeLine }}</p>
        <p>{{ oracleText }}</p>
        <p v-if="power && toughness">
            {{ power }} / {{ toughness }}
        </p>
        <b-row>
            <b-col sm="2">
                <label >Quantity : </label>
            </b-col>
            <b-col sm="2">
                <b-input type="number" min="0" v-model="quantity"></b-input>
            </b-col>
            <b-col sm="4">
                <b-button :disabled="disableIfSameQuantity" variant="success" v-on:click="updateQuantity">Update Quantity</b-button>
            </b-col>
        </b-row>
    </div>
</template>

<script>
import { ApiHelper } from '@/helpers/ApiHelper.js';

export default {
    name: 'Details',
    props: {
        itemData: Object
    },
    mounted: function() {
        this.id = this.itemData.id;
        this.name = this.itemData.name;
        this.manaCost = this.itemData.manaCost;
        this.cmc = this.itemData.cmc;
        this.typeLine = this.itemData.typeLine;
        this.oracleText = this.itemData.oracleText;
        this.setName = this.itemData.setName;
        this.power = this.itemData.power;
        this.toughness = this.itemData.toughness;
        this.commanderLegal = this.itemData.commanderLegal;
        this.quantity = this.itemData.quantity;
    },
    data: function() {
        return {
            id: 0,
            name: '',
            uri: '',
            scryfallUri: '',
            manaCost: '',
            cmc: 0,
            typeLine: '',
            oracleText: '',
            colors: '',
            colorIdentity: '',
            setName: '',
            power: '',
            toughness: '',
            flavorText: '',
            commanderLegal: true,
            quantity: 0,
            success: true,
            submitted: false
        };
    },
    methods: {
        updateQuantity: async function() {
            let helper = new ApiHelper();
            this.success = await helper.updateCardQuantity(this.id, this.quantity);
            console.log(this.success);
            this.submitted = true;
        }
    },
    computed: {
        disableIfSameQuantity: function() {
            return Number(this.quantity) === this.itemData.quantity;
        }
    }
}
</script>