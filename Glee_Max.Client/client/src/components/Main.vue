<template>
  <div>
    <h1>{{ msg }}</h1>
    <b-container class="main" fluid>
      <br/>
      <b-row>
        <b-col sm="3" />
        <b-col sm="6">
          <b-form-input :id="search-box" placeholder="Please enter a card name"/>
        </b-col>
        <b-col sm="3" />
      </b-row>
      <br/>
      <b-row>
        <b-col sm="5" />
        <b-col sm="2">
          <b-button variant="primary">Search</b-button>
        </b-col>
        <b-col sm="5" />
      </b-row>
    </b-container>
  </div>
</template>

<script>
export default {
  name: 'Main',
  props: {
    msg: String
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
