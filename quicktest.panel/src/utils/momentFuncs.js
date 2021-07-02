import moment from 'moment'

export function testDurationSeconds(startDate, endDate) {
    let startDateMoment = moment(startDate)
    let endDateMoment = moment(endDate)
    return endDateMoment.diff(startDateMoment, "seconds");
}
