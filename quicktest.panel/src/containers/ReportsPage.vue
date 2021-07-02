<style scoped>
.nounderline {
  text-decoration: none !important
}
</style>

<template>
  <div class="container">
    <div class="row mt-5">
      <div class="col-lg-3">
        <ul class="list-unstyled mt-3 mb-4">
          <li>Timing: {{ testcase.cycleTimingByMinutes }}</li>
          <li>Critical:
            <status-indicator :status="testcase.critical ? 'positive':'negative'"/>
          </li>
          <li>{{ testcase.steps.length }} Steps</li>
        </ul>
      </div>
      <div class="col-lg-6">
        <div class="card-header">
          <status-indicator :pulse="true" :status="testcase.active ? 'positive':'negative'" class="mt-3"/>
          {{ testcase.testName }}
        </div>
        <p class="text-truncate m-1">{{ testcase.websiteAddress }}</p>

      </div>
      <div class="col-lg-3">
        <ol>
          <div v-for="step in testcase.steps" :key="step.id">
            <li>{{ step.action }}</li>
          </div>
        </ol>
      </div>
    </div>
    <div class="row mt-5">
      <div v-for="report in this.reports" :key="report.id" class="col-lg-3">
        <router-link :to="{name:'SingleReportPage',params:{testReport: report,testcase:testcase}}" class="nounderline">
          <report-card :report="report" class=""></report-card>
        </router-link>
      </div>
    </div>
  </div>
</template>
<script>
import {mapState} from 'vuex'
import ReportCard from "@/components/ReportCard";
import {StatusIndicator} from 'vue-status-indicator';


export default {
  name: "ReportsPage",
  components: {ReportCard, StatusIndicator},
  computed: {
    ...mapState({
      reports: state => state.reports
    })
  },
  methods: {
    async getReports(id) {
      await this.$store.dispatch("getReportsOfTestcase", id)
    }
  },
  props: {
    testcase: Object
  },
  created() {
    this.getReports(this.testcase.id)
  }
}
</script>
