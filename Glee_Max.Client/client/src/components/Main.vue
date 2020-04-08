<template>
  <div>
    <h1>{{ msg }}</h1>
    <b-container class="main" fluid>
      <br/>
      <b-row>
        <b-col sm="3" />
        <b-col sm="6">
          <b-form-input v-model="searchString" placeholder="Please enter a card name"/>
        </b-col>
        <b-col sm="3" />
      </b-row>
      <br/>
      <b-row>
        <b-col sm="5" />
        <b-col sm="2">
          <b-button variant="primary" v-on:click="getCardsByNameSearch">Search</b-button>
        </b-col>
        <b-col sm="5" />
      </b-row>
      <br/>
      <b-row>
        <b-pagination v-model="currentPage" :total-rows="rows" :per-page="perPage" aria-controls="search-results"/>
        <b-table
          striped
          bordered
          small
          hover
          outlined
          head-variant='dark'
          :items="searchResults"
          :per-page="perPage"
          :current-page="currentPage"
          :fields="fields"
        >
          <template v-slot:cell(actions)>
            <b-button block variant="success">Details</b-button>
            <b-button block variant="primary">Edit quantity</b-button>
          </template>
        </b-table>
      </b-row>
    </b-container>
  </div>
</template>

<script>
import { ApiHelper } from '@/helpers/ApiHelper.js';
export default {
  name: 'Main',
  props: {
    msg: String
  },
  data: function() {
    return {
      perPage: 10,
      currentPage: 1,
      searchString: '',
      searchResults: [],
      fields: [
        {
          key: 'name',
          sortable: true
        },
        {
          key: 'manaCost',
          sortable: false
        },
        {
          key: 'typeLine',
          sortable: true
        },
        {
          key: 'setName',
          sortable: true
        },
        {
          key: 'power',
          sortable: true
        },
        {
          key: 'toughness',
          sortable: true
        },
        {
          key: 'commanderLegal',
          sortable: true
        },
        {
          key: 'quantity',
          sortable: true
        },
        {
          key: 'actions',
          sortable: false
        }
      ]
    };
  },
  methods: {
    getCardsByNameSearch: async function() {
      let helper = new ApiHelper();
      this.searchResults = await helper.getCardsViaSearch(this.searchString);
    }
  },
  computed: {
    rows() {
      return this.searchResults.length;
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.main {
  margin: auto;
}
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
