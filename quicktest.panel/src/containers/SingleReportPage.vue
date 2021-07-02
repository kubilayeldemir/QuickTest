<script>
import {testDurationSeconds} from "@/utils/momentFuncs";
import TestStep from "@/components/TestStep";

export default {
  name: "ReportPage",
  components: {TestStep},
  data() {
    return {
      sortedSteps: []
    }
  },
  props: {
    testReport: Object,
    testcase: Object,
  },
  methods: {
    sortList(objs) {
      this.sortedSteps = objs.sort(function (a, b) {
        return (a.stepNumber > b.stepNumber) ? 1 : ((b.stepNumber > a.stepNumber) ? -1 : 0);
      });
    }
  },
  mounted() {
    this.sortList(this.testReport.testSteps)
  },
  computed: {
    testDurationSeconds() {
      return testDurationSeconds(this.testReport.testStartDate, this.testReport.testEndDate)
    }
  }
}
</script>

<style scoped>

</style>

<template>
  <div class="container text-center">
    <div class="row mt-3">
      <div class="col-lg-6 offset-md-3">
        <div class="text-center">
          <h1>Test Report of {{ testcase.testName }}</h1>
        </div>
        <p class="ms-3">Test Status:
          <span :class="testReport.status ? 'bg-success':'bg-danger'" class="text-white p-2 py-1"
                style="position:center;">{{ testReport.status ? "Test Succeed" : "Test Failed" }}</span>
        </p>
        <div class="shadow p-3 mb-5 bg-white rounded">
          Test Report
        </div>
        <div class="alert alert-primary" role="alert">
          <p class="card-text mb-0">Test Started - Test Ended</p>
          <p class="card-text mb-0">{{ testReport.testStartDate | moment('h:mm:ss a') }}
            --> {{ testReport.testEndDate | moment('h:mm:ss a') }}</p>
          <p class="card-text mb-0"></p>
          <p class="card-text mb-0">Test took: {{ testDurationSeconds }} seconds </p>
        </div>
        <div v-if="!testReport.status" class="alert alert-danger" role="alert">
          Error Message: {{ testReport.errorMessage }}
        </div>
        <div v-for="step in sortedSteps" :key="step.id">
          <test-step :step="step"></test-step>
        </div>
      </div>
    </div>
  </div>
</template>
