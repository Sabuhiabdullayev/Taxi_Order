// Start Fromwhere List
let today = new Date(),
	day = today.getDate(),
	month = today.getMonth() + 1,
	year = today.getFullYear();
if (day < 10) {
	day = '0' + day
}
if (month < 10) {
	month = '0' + month
}
today = year + '-' + month + '-' + day;
document.getElementById("Date").setAttribute("min", today);
var fromwherecitytable=' <ul id="fromwherelist">'+

'<li> <span class="fromwherename">Agcabədi</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Ağdam</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Ağdaş</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Ağdərə</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Ağstafa</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Ağsu</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Astara</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Bakı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Balakən</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Beylaqan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Bərdə</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Biləsuvar</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Cəbrayıl</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Cəlilabad</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Culfa</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Daşkəsən</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Füzuli</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Gədəbəy</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Gəncə</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Goranboy</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Göyçay</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Göygöl</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Göytəpə</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Hacıqabul</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Horadiz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">İmişli</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">İsmayıllı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Kəlbəcər</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Kürdəmir</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Laçın</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Lerik</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Lənkəran</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Massallı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Mingəçəvir</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Nabran</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Naftalan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Naxçəvan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Neftçala</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Oğuz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Ordubad</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Qax</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Qazax</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Qəbələ</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Qobustan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Quba</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Qubadlı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Qusar</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Saatlı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Sabirabad</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Şabran</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Şahbuz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Salyan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Şamaxı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Samux</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Şəki</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Şəmkir</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Şərur</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Şirvan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Siyəzən</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Sumqayıt</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Şuşa</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Tərtər</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Tovuz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Ucar</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Xaçmaz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Xankəndi</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Xırdalan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Xızı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Xocalı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Xocavənd</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Xudat</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Yardımlı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Yevlax</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Zaqatala</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Zəngilan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li> <span class="fromwherename">Zərdab</span> <i class="fa-solid fa-arrow-right-long"></i></li>'
'</ul>';
$(".fromwherecity").html(fromwherecitytable);


// SEARCH FUNCTION
var btsearch = {
	init: function(search_field, searchable_elements, searchable_text_class) {
		$(search_field).keyup(function(e){
			e.preventDefault();
			$(".fromwhereloading").css('display','none');
			$(".fromwherecity").css('display','none');
			var query = $(this).val().toLowerCase();
			if(query){
				// loop through all elements to find match
				$.each($(searchable_elements), function(){
					var title = $(this).find(searchable_text_class).text().toLowerCase();
					if(title.indexOf(query) == -1){
						$(this).hide();
						$(".fromwherecity").css('display','block');
						$(".wherecity").css('display','none');
						$(".fromwhereloading").css('display','none');
					} else {
						$(this).show();
						$(".fromwhereloading").css('display','block');
					}
				});
			} else {
				// empty query so show everything
				$(searchable_elements).show();
			}
		});
	}
}

// INIT
$(function(){
  // USAGE: btsearch.init(('search field element', 'searchable children elements', 'searchable text class');
  btsearch.init('.fromwhereinput', '#fromwherelist li', '.fromwherename');
});

$("#fromwherelist").on('click',"li",function(){
    var btn =$(this);
    $(".fromwhereinput").val(btn.text());
	$(".fromwherecity").css('display',"none")
});
$("#fromwherelist").on('click',".fromwherecityname",function(){
	var btn=$(this);
	$(".fromwhereinput").val(btn.text())
	$(".fromwherecity").css('display',"none")

	});


// End Fromwhere List


// Start Where List

var wherecitytable=' <ul id="wherelist">'+

'<li>  <span class="wherename">Agcabədi</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Ağdam</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Ağdaş</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Ağdərə</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Ağstafa</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Ağsu</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Astara</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Bakı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Balakən</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Beylaqan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Bərdə</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Biləsuvar</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Cəbrayıl</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Cəlilabad</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Culfa</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Daşkəsən</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Füzuli</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Gədəbəy</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Gəncə</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Goranboy</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Göyçay</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Göygöl</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Göytəpə</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Hacıqabul</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Horadiz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">İmişli</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">İsmayıllı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Kəlbəcər</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Kürdəmir</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Laçın</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Lerik</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Lənkəran</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Massallı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Mingəçəvir</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Nabran</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Naftalan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Naxçəvan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Neftçala</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Oğuz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Ordubad</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Qax</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Qazax</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Qəbələ</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Qobustan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Quba</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Qubadlı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Qusar</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Saatlı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Sabirabad</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Şabran</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Şahbuz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Salyan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Şamaxı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Samux</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Şəki</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Şəmkir</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Şərur</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Şirvan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Siyəzən</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Sumqayıt</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Şuşa</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Tərtər</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Tovuz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Ucar</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Xaçmaz</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Xankəndi</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Xırdalan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Xızı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Xocalı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Xocavənd</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Xudat</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Yardımlı</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Yevlax</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Zaqatala</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Zəngilan</span> <i class="fa-solid fa-arrow-right-long"></i></li>'+
'<li>  <span class="wherename">Zərdab</span> <i class="fa-solid fa-arrow-right-long"></i></li>'
'</ul>';
$(".wherecity").html(wherecitytable);


// SEARCH FUNCTION
var btsearch2 = {
	init: function(search_field2, searchable_elements2, searchable_text_class2) {
		$(search_field2).keyup(function(e){
			e.preventDefault();
			$(".whereloading").css('display','none');
			$(".wherecity").css('display','none');
			var query = $(this).val().toLowerCase();
			if(query){
				// loop through all elements to find match
				$.each($(searchable_elements2), function(){
					var title = $(this).find(searchable_text_class2).text().toLowerCase();
					if(title.indexOf(query) == -1){
						$(this).hide();
						$(".wherecity").css('display','block');
						$(".fromwherecity").css('display','none');
						$(".whereloading").css('display','none');
					} else {
						$(this).show();
						$(".whereloading").css('display','block');
					}
				});
			} else {
				// empty query so show everything
				$(searchable_elements2).show();
			}
		});
	}
}

// INIT
$(function(){
  // USAGE: btsearch2.init(('search field element', 'searchable children elements', 'searchable text class');
  btsearch2.init('.whereinput', '#wherelist li', '.wherename');
});

$("#wherelist").on('click',"li",function(){
    var btn =$(this);
    $(".whereinput").val(btn.text());
	$(".wherecity").css('display',"none")
});
$("#wherelist").on('click',".wherecityname",function(){
	var btn=$(this);
	$(".whereinput").val(btn.text())
	$(".wherecity").css('display',"none")

	});

// End Where List

