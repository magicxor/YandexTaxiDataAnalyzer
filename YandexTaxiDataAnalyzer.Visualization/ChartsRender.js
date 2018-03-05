function createRow(divId) {
    $("#container").append('<div class="row"><div id="' + divId + '" class="col-md"></div></div>');
}

function addSingleValue(divId, caption, value) {
    createRow(divId);
    $('#' + divId).append('<p class="text-center"><b>' + caption + ': ' + value + '</b></p>');
}

function renderAsColumnChart(divId, chartName, data) {
    createRow(divId);
    Highcharts.chart(divId, {
        chart: {
            type: 'column'
        },
        title: {
            text: chartName
        },
        xAxis: {
            type: 'category'
        },
        plotOptions: {
            column: {
                dataLabels: {
                    enabled: true
                }
            }
        },
        series: [{
            name: chartName,
            data: data
        }]
    });
}

function renderAsPieChart(divId, chartName, data) {
    createRow(divId);
    Highcharts.chart(divId, {
        chart: {
            type: 'pie'
        },
        title: {
            text: chartName
        },
        plotOptions: {
            pie: {
                dataLabels: {
                    enabled: true,
                    format: '<b>{point.name}</b>: {point.percentage:.1f} %'
                }
            }
        },
        series: [{
            name: chartName,
            data: data
        }]
    });
}

function renderValueAndCountColumnChart(divId, chartName1, chartName2, data1, data2) {
    createRow(divId);
    Highcharts.chart(divId, {
        chart: {
            type: 'column'
        },
        title: {
            text: chartName1 + " and " + chartName2
        },
        xAxis: {
            type: 'category'
        },
        yAxis: [{ // Primary yAxis
            showLastLabel: false
        }, { // Secondary yAxis
            title: {
                text: 'Count'
            },
            opposite: true,
            visible: false
        }],
        plotOptions: {
            column: {
                dataLabels: {
                    enabled: true
                }
            }
        },
        series: [{
            name: chartName1,
            data: data1
        },
            {
                name: chartName2,
                data: data2,
                yAxis: 1
            }]
    });
}