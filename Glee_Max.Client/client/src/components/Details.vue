<template>
    <div>
        <h4>{{ this.name }}</h4>
        <p v-if="this.commanderLegal === false"><strong>Not Commander Legal</strong></p>
        <p>{{ this.manaCost }} - (converted mana cost: {{ this.cmc }})</p>
        <p>{{ this.setName }}</p>
        <p>{{ this.typeLine }}</p>
        <p>{{ this.oracleText }}</p>
        <p v-if="this.power && this.toughness">
            {{ this.power }} / {{ this.toughness }}
        </p>
        <b-row>
            <b-col sm="2">
                <label >Quantity</label>
            </b-col>
            <b-col sm="10">
                <b-input type="number" min="0" :value="this.quantity"></b-input>
            </b-col>
        </b-row>
    </div>
</template>

<script>
export default {
    name: 'Details',
    props: {
        itemData: Object
    },
    mounted: function() {
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
            quantity: 0
        };
    }
}
</script>