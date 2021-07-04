<script>
export default {
  name: "CreateTestButton"
}
</script>

<template>
<div class="container">
  <router-link :to="{name:'TestCaseCreatePage'}" class="nounderline">
    <button type="button" class="btn btn-primary ms-5">Click Here To Create a New Test Case</button>
  </router-link>
</div>
</template>



<style scoped>

</style>
