<script>
import {testDurationSeconds} from "@/utils/momentFuncs";

export default {
  name: "ReportCard",
  data() {
    return {}
  },
  props: {
    report: Object
  },
  components: {},
  computed: {
    testDurationSeconds() {
      return testDurationSeconds(this.report.testStartDate, this.report.testEndDate)
    }
  },
  methods: {}
}
</script>

<style scoped>

</style>
<template>
  <div :class="report.status ? 'bg-success' : 'bg-danger' " class="card text-white mb-3 mx-5 mx-lg-0" style="max-width: 100%;">
    <div class="card-header"><span>{{ report.testStartDate | moment('h:mm A YYYY-MM-DD') }}</span></div>
    <div class="card-body">
      <h5 v-if="report.status" class="card-title">Test Passed</h5>
      <h5 v-else class="card-title">Test Failed!</h5>
      <p class="card-text mb-0">Started at: {{ report.testStartDate | moment('h:mm:ss ') }} </p>
      <p class="card-text mb-0">End at: {{ report.testEndDate | moment('h:mm:ss ') }} </p>
      <p class="card-text mb-0">Took: {{ testDurationSeconds }} seconds </p>
    </div>
  </div>
</template>
