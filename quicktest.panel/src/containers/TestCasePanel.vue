<script>
import {mapState} from 'vuex'
import TestCase from "@/components/TestCaseCard";
import CreateTestButton from "@/components/CreateTestButton";

export default {
  name: "TestCasePanel",
  components: {CreateTestButton, TestCase},
  data() {
    return {}
  },
  computed: {
    ...mapState({
      testcases: state => state.testcases
    })
  },
  methods: {
    async getTestcases() {
      await this.$store.dispatch("getTestcases");
    }
  },
  created() {
    this.getTestcases();
  }
}
</script>

<style scoped>

</style>

<template>
  <div class="container">
    <div class="row">
      <create-test-button class="mt-5 text-center"></create-test-button>
    </div>
    <div class="row justify-content-center mt-5">
      <div v-for="testcase in testcases" :key="testcase.id" class="col-12 col-lg-3">
        <test-case :testcase="testcase"></test-case>
      </div>
    </div>
  </div>
</template>
