<script>
import {mapState} from 'vuex'
import ReportCard from "@/components/ReportCard";

export default {
  name: "ReportsPage",
  components: {ReportCard},
  computed:{
    ...mapState({
      reports:state => state.reports
    })
  },
  methods:{
    async getReports(id){
      await this.$store.dispatch("getReportsOfTestcase",id)
    }
  },
  props:{
    testcaseId: Number
  },
  created() {
    this.getReports(this.testcaseId)
  }
}
</script>

<style scoped>

</style>

<template>
  <div class="container">
    <div class="row mt-5">
      <div v-for="report in this.reports" :key="report.id" class="col-3">
        <report-card :report="report" class=""></report-card>
      </div>
    </div>
  </div>
</template>
